using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RE4_PS2_Toolset.Forms.CAM
{
    public partial class CAMForm : Form
    {
        CAM cam = new CAM();
        string filepath = "";
        public CAMForm()
        {
            InitializeComponent();
        }

        private void OpenFile()
        {
            DialogResult result = DialogResult.Yes;
            if (filepath != "")
            {
                result = MessageBox.Show("There is another file already open, are you sure?", "File already open",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (result == DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CAM File (*.CAM)|*.CAM";
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {
                    filepath = openFileDialog.FileName;
                    this.Text = "CAM Tool - " + openFileDialog.FileName;
                }
                ReadFile();
            }
        }

        private void ReadFile()
        {
            BinaryReader br = new BinaryReader(File.OpenRead(filepath));
            cam.Magic = br.ReadInt32();
            cam.CameraCount1 = br.ReadByte();
            cam.CameraCount2 = br.ReadByte();
            cam.HeaderUnk1 = br.ReadBytes(0x09);
            if (cam.CameraCount2 > 0)
            {
                ReadCameraEntry(0);
            }
            br.Close();

            // Status bar
            statusCameraCount.Text = $"{cam.CameraCount2} cameras";
            statusText.Text = "CAM file loaded";
        }

        private void ReadCameraEntry(int entryNumber)
        {
            if (filepath != "")
            {
                BinaryReader br = new BinaryReader(File.OpenRead(filepath));
                if (cam.CameraCount2 > 0)
                {
                    br.BaseStream.Position = 0x10 + 0x10 * entryNumber;
                    cam.EntryID = br.ReadByte();
                    cam.EntryUnk1 = br.ReadBytes(0x07);
                    cam.EntryPointerProperties1 = br.ReadUInt32();
                    cam.EntryPointerProperties2 = br.ReadUInt32();
                }

                // Get properties 1
                br.BaseStream.Position = cam.EntryPointerProperties1;
                cam.Prop1Active = br.ReadByte();
                cam.Prop1LightGroupIndex = br.ReadByte();
                cam.Prop1Unused1 = br.ReadByte();
                cam.Prop1EntryID = br.ReadByte();
                cam.Prop1Padding1 = br.ReadInt32();
                cam.Prop1Unk1 = br.ReadInt32();
                cam.Prop1Unk2 = br.ReadBytes(0x14);
                cam.Prop1Height = br.ReadSingle();
                cam.Prop1PositionY = br.ReadSingle();
                cam.Prop1VerticesCount = br.ReadInt32();
                cam.Prop1PointerTriggerzone = br.ReadUInt32();

                // Get properties 2
                br.BaseStream.Position = cam.EntryPointerProperties2;
                cam.Prop2Active = br.ReadByte();
                cam.Prop2LightGroupIndex = br.ReadByte();
                cam.Prop2CameraType = br.ReadByte();
                cam.Prop2Unk1 = br.ReadByte();
                cam.Prop2Padding1 = br.ReadInt32();
                cam.Prop2Unk2 = br.ReadInt32();
                cam.Prop2Unk3 = br.ReadBytes(0x14);
                cam.Prop2DatasetCount = br.ReadInt32();
                cam.Prop2PointerPosition = br.ReadUInt32();
                cam.Prop2PointerDirection = br.ReadUInt32();
                cam.Prop2PointerPan = br.ReadUInt32();
                cam.Prop2PointerZoom = br.ReadUInt32();

                // Get triggerzones
                br.BaseStream.Position = cam.Prop1PointerTriggerzone;
                cam.TriggerzoneBytes = br.ReadBytes(0x0C * cam.Prop1VerticesCount);

                // Get position
                br.BaseStream.Position = cam.Prop2PointerPosition;
                cam.CameraPosBytes = br.ReadBytes(0x10 * cam.Prop2DatasetCount);

                // Get direction
                br.BaseStream.Position = cam.Prop2PointerDirection;
                cam.CameraDirectionBytes = br.ReadBytes(0x10 * cam.Prop2DatasetCount);

                // Get pan
                br.BaseStream.Position = cam.Prop2PointerPan;
                cam.CameraPanBytes = br.ReadBytes(0x4 * cam.Prop2DatasetCount);

                // Get zoom
                br.BaseStream.Position = cam.Prop2PointerZoom;
                cam.CameraZoomBytes = br.ReadBytes(0x4 * cam.Prop2DatasetCount);

                br.Close();
            }
        }

        private byte GetCameraCount()
        {
            BinaryReader br = new BinaryReader(File.OpenRead(filepath));
            br.BaseStream.Position = 0x05;
            byte camCount = br.ReadByte();
            br.Close();

            statusCameraCount.Text = $"{camCount} cameras";
            return camCount;
        }

        private uint[] GetPointersProperties(int propertiesIndex)
        {
            byte camCount = GetCameraCount();
            int startingOffset = 0;
            switch (propertiesIndex)
            {
                case 0:
                    startingOffset = 0x18;
                    break;
                case 1:
                    startingOffset = 0x1C;
                    break;
                default:
                    Console.WriteLine($"Properties index '{propertiesIndex}' invalid");
                    break;
            }

            BinaryReader br = new BinaryReader(File.OpenRead(filepath));
            uint[] propertiesArray = new uint[camCount];
            for (int pointer = 0; pointer < camCount; pointer++)
            {
                br.BaseStream.Position = startingOffset + 0x10 * pointer;
                propertiesArray[pointer] = br.ReadUInt32();
            }
            br.Close();
            return propertiesArray;
        }

        private uint[] GetPointersTriggerzones()
        {
            byte camCount = GetCameraCount();
            uint[] pointersProperties = GetPointersProperties(0);
            uint[] pointersTriggerzones = new uint[camCount];

            // Get all pointers from properties 1
            BinaryReader br = new BinaryReader(File.OpenRead(filepath));
            for (int pointer = 0; pointer < camCount; pointer++)
            {
                br.BaseStream.Position = pointersProperties[pointer] + 0x2C;
                pointersTriggerzones[pointer] = br.ReadUInt32();
            }
            br.Close();

            return pointersTriggerzones;
        }

        private uint[] GetPointersPosDirPanZoom(string pointerName = "position")
        {
            byte camCount = GetCameraCount();
            int startingOffset = 0;
            switch (pointerName)
            {
                case "position":
                    startingOffset = 0x24;
                    break;
                case "direction":
                    startingOffset = 0x28;
                    break;
                case "pan":
                    startingOffset = 0x2C;
                    break;
                case "zoom":
                    startingOffset = 0x30;
                    break;
                default:
                    Console.WriteLine($"Pointer name '{pointerName}' invalid");
                    break;
            }

            uint[] pointersProperties2 = GetPointersProperties(1);
            uint[] pointers = new uint[camCount];

            // Get all pointers from properties 2
            BinaryReader br = new BinaryReader(File.OpenRead(filepath));
            for (int pointer = 0; pointer < camCount; pointer++)
            {
                br.BaseStream.Position = pointersProperties2[pointer] + startingOffset;
                pointers[pointer] = br.ReadUInt32();
            }
            br.Close();

            return pointers;
        }

        private uint[] GetVerticesCount()
        {
            // This method gets all vertices count from all Properties 1 group
            // and put them into an array
            byte camCount = GetCameraCount();
            uint[] pointersProperties = GetPointersProperties(0);
            uint[] verticesArray = new uint[camCount];

            // Get all vertices count from properties 1
            BinaryReader br = new BinaryReader(File.OpenRead(filepath));
            for (int index = 0; index < camCount; index++)
            {
                br.BaseStream.Position = pointersProperties[index] + 0x28;
                verticesArray[index] = br.ReadUInt32();
            }
            br.Close();

            return verticesArray;
        }

        private uint[] GetDatasetCount()
        {
            // This method gets all dataset count from all Properties 2 groups
            // and put them into an array
            byte camCount = GetCameraCount();
            uint[] pointersProperties = GetPointersProperties(1);
            uint[] datasetArray = new uint[camCount];

            // Get all vertices count from properties 1
            BinaryReader br = new BinaryReader(File.OpenRead(filepath));
            for (int index = 0; index < camCount; index++)
            {
                br.BaseStream.Position = pointersProperties[index] + 0x20;
                datasetArray[index] = br.ReadUInt32();
            }
            br.Close();

            return datasetArray;
        }

        private byte[] GetEntriesID(string activationType = "all")
        {
            // This method gets all camera entries ID to identify which ones are inspection types (0x03)
            byte camCount = GetCameraCount();
            byte[] entriesArray = new byte[camCount];

            // Get all entries ID
            BinaryReader br = new BinaryReader(File.OpenRead(filepath));

            switch (activationType)
            {
                case "inspection":
                    for (int index = 0; index < camCount; index++)
                    {
                        br.BaseStream.Position = 0x10 + (0x10 * index);
                        byte temp = br.ReadByte();
                        if (temp == 4)
                        {
                            entriesArray[index] = temp;
                        }
                    }
                    break;
                default:
                    for (int index = 0; index < camCount; index++)
                    {
                        br.BaseStream.Position = 0x10 + (0x10 * index);
                        entriesArray[index] = br.ReadByte();
                    }
                    break;
            }

            br.Close();

            return entriesArray;
        }

        private void UpdateOffsetsProperties1()
        {
            byte camCount = GetCameraCount();
            int[] pointersProp1 = new int[camCount];

            BinaryWriter bw = new BinaryWriter(File.OpenWrite(filepath));

            // Update prop 1 offsets
            for (int i = 0; i < camCount; i++)
            {
                bw.BaseStream.Position = 0x18 + 0x10 * i;
                bw.Write(0x10 + (camCount * 0x10) + (0x30 * i));
                pointersProp1[i] = 0x10 + (camCount * 0x10) + (0x30 * i);
            }
            bw.Close();
        }

        private void UpdateOffsetsProperties2()
        {
            byte camCount = GetCameraCount();
            uint[] pointersProp1 = GetPointersProperties(0);
            uint[] pointersProp2 = new uint[camCount];
            int acumulator = 0x30;

            BinaryWriter bw = new BinaryWriter(File.OpenWrite(filepath));

            // Update prop 2 offsets
            for (int i = 0; i < camCount; i++)
            {
                bw.BaseStream.Position = 0x1C + 0x10 * i;
                bw.Write((uint)(pointersProp1.Last() + (0x30 * i) + acumulator));

                pointersProp2[i] = (uint)(pointersProp1.Last() + (0x30 * i) + acumulator);
                acumulator += 4;
            }
            bw.Close();
        }

        private void UpdateOffsetsTriggerzones()
        {
            byte camCount = GetCameraCount();
            int acumulator = 0x34;

            // Update offsets separately
            UpdateOffsetsProperties1();
            UpdateOffsetsProperties2();

            uint[] pointersProp1 = GetPointersProperties(0);
            uint[] pointersProp2 = GetPointersProperties(1);
            uint[] pointersTrigg = GetPointersTriggerzones();
            uint[] verticesArray = GetVerticesCount();

            BinaryWriter bw = new BinaryWriter(File.OpenWrite(filepath));

            // Update triggerzones offsets
            for (int i = 0; i < camCount; i++)
            {
                bw.BaseStream.Position = pointersProp1[i] + 0x2C;
                bw.Write((uint)(pointersProp2.Last() + acumulator));

                pointersTrigg[i] = (uint)(pointersProp2.Last() + acumulator);
                acumulator += (int)(0x0C * verticesArray[i]);
            }
            bw.Close();
        }

        private void UpdateOffsetsPosDirPanZoom()
        {
            byte camCount = GetCameraCount();
            uint[] pointersProp2 = GetPointersProperties(1);
            uint[] pointersTriggerzones = GetPointersTriggerzones();
            uint[] verticesCount = GetVerticesCount();
            uint[] datasetCount = GetDatasetCount();
            uint firstPositionOffset = pointersTriggerzones.Last() + (verticesCount.Last() * 0x0C);
            uint acumulator = firstPositionOffset;

            BinaryWriter bw = new BinaryWriter(File.OpenWrite(filepath));

            // Update offsets
            for (int i = 0; i < camCount; i++)
            {
                // Position 
                bw.BaseStream.Position = pointersProp2[i] + 0x24;
                bw.Write(acumulator);
                acumulator += datasetCount[i] * 0x10;

                // Direction 
                bw.BaseStream.Position = pointersProp2[i] + 0x28;
                bw.Write(acumulator);
                acumulator += datasetCount[i] * 0x10;

                // Pan
                bw.BaseStream.Position = pointersProp2[i] + 0x2C;
                bw.Write(acumulator);
                acumulator += datasetCount[i] * 0x4;

                // Zoom 
                bw.BaseStream.Position = pointersProp2[i] + 0x30;
                bw.Write(acumulator);
                acumulator += datasetCount[i] * 0x4;
            }
            bw.Close();
        }

        private void UpdateAllOffsets()
        {
            UpdateOffsetsProperties1();
            UpdateOffsetsProperties2();
            UpdateOffsetsTriggerzones();
            UpdateOffsetsPosDirPanZoom();
        }

        private void btnGenerateEntry_Click(object sender, EventArgs e)
        {
            ReadCameraEntry(cam.CameraCount2 - 1);
            uint[] pointersPosition = GetPointersPosDirPanZoom("position");
            uint[] pointersZoom = GetPointersPosDirPanZoom("zoom");
            uint[] datasetCount = GetDatasetCount();
            byte[] entriesArray = GetEntriesID();
            uint inspectionCameraBytes = 0;

            // Count how many inspection type camera exists
            for (int i = 0; i < entriesArray.Length; i++)
            {
                if (entriesArray[i] == 4)
                {
                    inspectionCameraBytes += datasetCount[i];
                }
            }

            BinaryReader br = new BinaryReader(File.OpenRead(filepath));
            byte[] part1Header = br.ReadBytes(0x10 + 0x10 * cam.CameraCount2);
            byte[] part2Prop1 = br.ReadBytes(0x30 * cam.CameraCount2);
            byte[] part3Prop2 = br.ReadBytes(0x34 * cam.CameraCount2);
            byte[] part4Trigg = br.ReadBytes((int)(pointersPosition.First() - br.BaseStream.Position));
            byte[] part5PosRot = br.ReadBytes((int)(pointersZoom.Last() + (4 * datasetCount.Last()) - br.BaseStream.Position)); // Pos, Rot, Pan/Zoom
            byte[] part6Time = br.ReadBytes((int)(2 * inspectionCameraBytes));
            br.Close();

            // Write new entry
            BinaryWriter bw = new BinaryWriter(File.Create(filepath));

            // Add new entry
            bw.Write(part1Header);
            bw.Write((byte)spinActivationType.Value);
            bw.Write(new byte[0x07]);
            bw.Write(cam.EntryPointerProperties1 + 0x40);
            bw.Write(cam.EntryPointerProperties2 + 0x40);

            // Add properties 1
            bw.Write(part2Prop1);
            bw.Write(cam.Prop1Active);
            bw.Write(cam.Prop1LightGroupIndex);
            bw.Write(cam.Prop1Unused1);
            bw.Write(cam.Prop1EntryID);
            bw.Write(cam.Prop1Padding1);
            bw.Write(cam.Prop1Unk1);
            bw.Write(cam.Prop1Unk2);
            bw.Write(cam.Prop1Height);
            bw.Write(cam.Prop1PositionY);
            bw.Write((int)spinVerticesCount.Value);
            bw.Write(cam.Prop1PointerTriggerzone + 0x40);

            // Add properties 2 
            bw.Write(part3Prop2);
            bw.Write(cam.Prop2Active);
            bw.Write((byte)spinLightGroup.Value);
            bw.Write((byte)spinCameraType.Value);
            bw.Write(cam.Prop2Unk1);
            bw.Write(cam.Prop2Padding1);
            bw.Write(cam.Prop2Unk2);
            bw.Write(cam.Prop2Unk3);
            bw.Write((int)spinDatasetCount.Value);

            uint properties2PointerSection = (uint)bw.BaseStream.Position;
            bw.Write(cam.Prop2PointerPosition);
            bw.Write(cam.Prop2PointerDirection);
            bw.Write(cam.Prop2PointerPan);
            bw.Write(cam.Prop2PointerZoom);

            // Add triggerzones
            bw.Write(part4Trigg);
            bw.Write(new byte[0x0C * (int)spinVerticesCount.Value]);

            // Add position
            bw.Write(part5PosRot);
            uint positionStartOffset = (uint)bw.BaseStream.Position; // Get offset for position pointer
            for (int i = 0; i < (int)spinDatasetCount.Value; i++)
            {
                bw.Write(new byte[0x0C]);
                bw.Write(cam.CameraPosPadding);
            }

            // Add direction
            uint directionStartOffset = (uint)bw.BaseStream.Position; // Get offset for direction pointer
            for (int i = 0; i < (int)spinDatasetCount.Value; i++)
            {
                bw.Write(new byte[0x0C]);
                bw.Write(cam.CameraDirectionPadding);
            }

            // Add pan
            uint panStartOffset = (uint)bw.BaseStream.Position; // Get offset for pan pointer
            for (int i = 0; i < (int)spinDatasetCount.Value; i++)
            {
                bw.Write(new byte[0x04]);
            }

            // Add zoom
            uint zoomStartOffset = (uint)bw.BaseStream.Position; // Get offset for zoom pointer
            for (int i = 0; i < (int)spinDatasetCount.Value; i++)
            {
                bw.Write(new byte[0x04]);
            }

            // Adds inspection camera timing
            bw.Write(part6Time);

            // Adds padding to the end if needed
            if (bw.BaseStream.Length % 16 != 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    bw.Write((ushort)0xCDCD);
                }
            }

            // Updates index
            bw.BaseStream.Position = 0;
            bw.Write(cam.Magic);
            bw.Write((byte)(cam.CameraCount1 + 1));
            bw.Write((byte)(cam.CameraCount2 + 1));
            cam.CameraCount1++;
            cam.CameraCount2++;

            // Updates pointer in properties 2
            bw.BaseStream.Position = properties2PointerSection;
            bw.Write(positionStartOffset);
            bw.Write(directionStartOffset);
            bw.Write(panStartOffset);
            bw.Write(zoomStartOffset);
            bw.Close();

            UpdateAllOffsets();
            statusText.Text = "New camera entry added";
        }

        private void loadCAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
    }
}
