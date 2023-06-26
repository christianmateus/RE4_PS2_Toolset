using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RE4_PS2_Toolset.Forms.ETS
{
    public partial class ETSForm : Form
    {
        public ETSForm()
        {
            InitializeComponent();
        }
        string filepath = "";
        int globalSelectedRow = 0;
        ETS ets = new ETS();

        public void OpenFile()
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
                openFileDialog.Filter = "ETS File (*.ETS)|*.ETS";
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {
                    filepath = openFileDialog.FileName;
                    this.Text = "ETS Tool - " + openFileDialog.FileName;
                    CreateTable();
                }
            }
        }

        public void CreateTable()
        {
            int objectQuantity = GetObjectQuantity();
            table.Columns.Clear();

            DataGridViewTextBoxColumn objNumber = new DataGridViewTextBoxColumn();
            objNumber.HeaderText = "Nº";
            objNumber.Width = 60;
            objNumber.ReadOnly = true;
            objNumber.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns.Insert(0, objNumber);

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Image";
            imageColumn.Width = 80;
            table.Columns.Insert(1, imageColumn);

            DataGridViewComboBoxColumn objectName = new DataGridViewComboBoxColumn();
            objectName.HeaderText = "Object Name";
            objectName.Width = 110;
            objectName.DataSource = ets.ETSList.Values.ToList<string>();
            table.Columns.Insert(2, objectName);

            DataGridViewTextBoxColumn objectIndex = new DataGridViewTextBoxColumn();
            objectIndex.HeaderText = "Index";
            objectIndex.Width = 60;
            objectIndex.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns.Insert(3, objectIndex);

            DataGridViewTextBoxColumn posX = new DataGridViewTextBoxColumn();
            posX.HeaderText = "Position X";
            posX.Width = 80;
            posX.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns.Insert(4, posX);

            DataGridViewTextBoxColumn posY = new DataGridViewTextBoxColumn();
            posY.HeaderText = "Position Y";
            posY.Width = 80;
            posY.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns.Insert(5, posY);

            DataGridViewTextBoxColumn posZ = new DataGridViewTextBoxColumn();
            posZ.HeaderText = "Position Z";
            posZ.Width = 80;
            posZ.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns.Insert(6, posZ);

            DataGridViewTextBoxColumn rotX = new DataGridViewTextBoxColumn();
            rotX.HeaderText = "Rotation X";
            rotX.Width = 80;
            rotX.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns.Insert(7, rotX);

            DataGridViewTextBoxColumn rotY = new DataGridViewTextBoxColumn();
            rotY.HeaderText = "Rotation Y";
            rotY.Width = 80;
            rotY.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns.Insert(8, rotY);

            DataGridViewTextBoxColumn rotZ = new DataGridViewTextBoxColumn();
            rotZ.HeaderText = "Rotation Z";
            rotZ.Width = 80;
            rotZ.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns.Insert(9, rotZ);

            LoadObjects();
        }

        public void LoadObjects()
        {
            int objectQuantity = GetObjectQuantity();
            statusObjectQuantity.Text = objectQuantity.ToString() + " objects";

            if (filepath != "")
            {
                BinaryReader br = new BinaryReader(File.OpenRead(filepath));
                br.BaseStream.Position = 0x10;

                for (int i = 0; i < objectQuantity; i++)
                {
                    ets.ScaleX = br.ReadUInt32();
                    ets.ScaleY = br.ReadUInt32();
                    ets.ScaleZ = br.ReadUInt32();
                    ets.Padding = br.ReadUInt32();
                    ets.RotationX = br.ReadSingle();
                    ets.RotationY = br.ReadSingle();
                    ets.RotationZ = br.ReadSingle();
                    ets.Padding = br.ReadUInt32();
                    ets.PositionX = br.ReadSingle();
                    ets.PositionY = br.ReadSingle();
                    ets.PositionZ = br.ReadSingle();
                    ets.Padding = br.ReadUInt32();
                    ets.ObjectID = br.ReadUInt16();
                    ets.Index = br.ReadUInt16();
                    br.ReadBytes(0x0C); // padding after index

                    // Get object name
                    string objectName = "";
                    for (int k = 0; k < ets.ETSList.Values.Count; k++)
                    {
                        if (ets.ObjectID == ets.ETSList.Keys.ToArray()[k])
                        {
                            objectName = ets.ETSList.Values.ToArray()[k];
                        }
                    }

                    var index = table.Rows.Add();
                    table.Rows[index].Cells[0].Value = i;
                    table.Rows[index].Cells[2].Value = objectName;
                    table.Rows[index].Cells[1].Value = (Bitmap)Properties.Resources.ResourceManager.GetObject($"_{ets.ObjectID}");
                    table.Rows[index].Cells[3].Value = ets.Index;
                    table.Rows[index].Cells[4].Value = ets.PositionX;
                    table.Rows[index].Cells[5].Value = ets.PositionY;
                    table.Rows[index].Cells[6].Value = ets.PositionZ;
                    table.Rows[index].Cells[7].Value = ets.RotationX;
                    table.Rows[index].Cells[8].Value = ets.RotationY;
                    table.Rows[index].Cells[9].Value = ets.RotationZ;
                }
                br.Close();
                UpdateStatusText("ETS File loaded", $"{objectQuantity} objects");
            }
        }

        public void SaveFile()
        {

        }

        public int GetObjectQuantity()
        {
            if (filepath != "")
            {
                BinaryReader br = new BinaryReader(File.OpenRead(filepath));
                int objectQuantity = br.ReadInt32();
                br.Close();

                return objectQuantity;
            }
            else
            {
                return 0;
            }
        }

        public void UpdateStatusText(string mainText, string countText)
        {
            statusText.Text = mainText;
            statusObjectQuantity.Text = countText;
            statusStrip1.Refresh();
        }

        public void FormatTable()
        {

        }

        public void AddNewObject()
        {
            int objectQuantity = GetObjectQuantity();
            if (filepath != "")
            {
                BinaryWriter bw = new BinaryWriter(File.OpenWrite(filepath));
                bw.BaseStream.Position = 0x10 + (objectQuantity * 0x40);

                // Scale
                for (int i = 0; i < 3; i++)
                {
                    bw.Write((float)1);
                }

                // Rotation, Position and padding
                for (int i = 0; i < 9; i++)
                {
                    bw.Write((uint)0);
                }

                bw.Write((ushort)0);
                if (table.Rows.Count == 0)
                {
                    bw.Write((ushort)0);
                }
                else
                {
                    bw.Write((ushort)(Convert.ToUInt16(table.Rows[table.Rows.Count - 1].Cells[3].Value) + 1));
                }
                bw.Write(new byte[0x0C]);

                // Updates object count in ETS
                bw.BaseStream.Position = 0;
                bw.Write(objectQuantity + 1);

                var index = table.Rows.Add();
                table.Rows[index].Cells[0].Value = objectQuantity + 1;
                table.Rows[index].Cells[1].Value = (Bitmap)Properties.Resources.ResourceManager.GetObject("_0");
                table.Rows[index].Cells[2].Value = "Window";

                if (table.Rows.Count == 1)
                {
                    bw.Write((ushort)0);
                    table.Rows[index].Cells[3].Value = 0;
                }
                else
                {
                    table.Rows[index].Cells[3].Value = Convert.ToInt16(table.Rows[index - 1].Cells[3].Value) + 1;
                }

                table.Rows[index].Cells[4].Value = 0;
                table.Rows[index].Cells[5].Value = 0;
                table.Rows[index].Cells[6].Value = 0;
                table.Rows[index].Cells[7].Value = 0;
                table.Rows[index].Cells[8].Value = 0;
                table.Rows[index].Cells[9].Value = 0;
                bw.Write(new byte[0x0C]);
                bw.Close();
                UpdateStatusText($"Object {table.Rows.Count} added", $"{table.Rows.Count} objects");
            }
        }

        public void RemoveObject()
        {
            if (filepath != "" && table.Rows.Count > 0)
            {
                BinaryReader br = new BinaryReader(File.OpenRead(filepath));

                // Get object count
                ushort objectQuantity = br.ReadUInt16();
                br.BaseStream.Position = 0;

                // Get top part
                byte[] topPart = br.ReadBytes(0x10 + (globalSelectedRow * 0x40));
                br.BaseStream.Position += 0x40;

                // Get bottom part
                byte[] bottomPart = br.ReadBytes((int)(br.BaseStream.Length - br.BaseStream.Position));
                br.Close();

                // Write new file
                BinaryWriter bw = new BinaryWriter(File.Create(filepath));
                bw.Write(topPart);
                bw.Write(bottomPart);

                // Update count
                bw.BaseStream.Position = 0;
                bw.Write(objectQuantity - 1);
                bw.Close();

                table.Rows.RemoveAt(globalSelectedRow);
                UpdateStatusText($"Object {globalSelectedRow} removed", GetObjectQuantity().ToString() + " objects");
            }
        }

        public void DuplicateObject()
        {
            if (filepath != "")
            {
                // Gets selected object
                BinaryReader br = new BinaryReader(File.OpenRead(filepath));
                ushort objectQuantity = br.ReadUInt16();
                br.BaseStream.Position = (globalSelectedRow * 0x40) + 0x10;
                byte[] etsObject = br.ReadBytes(0x40);
                br.Close();

                // Writes new object at the end of the file
                BinaryWriter bw = new BinaryWriter(File.OpenWrite(filepath));
                bw.Write(objectQuantity + 1);
                bw.BaseStream.Position = bw.BaseStream.Length;
                bw.Write(etsObject);
                bw.Close();

                // Updates table
                CreateTable();
                UpdateStatusText($"Object {globalSelectedRow} duplicated", GetObjectQuantity().ToString() + " objects");
            }
        }


        private void addNewObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewObject();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewObject();
        }

        private void removeObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveObject();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveObject();
        }

        private void table_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                globalSelectedRow = e.RowIndex;
            }

            if (e.Button == MouseButtons.Right)
            {
                tableContextMenu.Show(new Point(MousePosition.X, MousePosition.Y));
            }
        }

        private void removeObjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemoveObject();
        }

        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filepath != "" && table.Rows.Count > 0)
            {
                BinaryWriter bw = new BinaryWriter(File.Create(filepath));
                bw.Write(new byte[0x10]);
                bw.Close();

                this.Text = $"ETS Tool - {filepath}";
                CreateTable();
                UpdateStatusText("Removed all objects", "0 objects");
            }
        }

        // Drag and drop

        private void ETSForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void ETSForm_DragDrop(object sender, DragEventArgs e)
        {
            DialogResult result = DialogResult.Yes;
            if (filepath != "")
            {
                result = MessageBox.Show("There is another file already open, are you sure?", "File already open",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (result == DialogResult.Yes)
            {
                string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                if (Path.GetExtension(fileList[0]).ToLower() == ".ets")
                {
                    filepath = fileList[0];
                    this.Text = "ETS Tool - " + filepath;
                    CreateTable();
                }
                else
                {
                    MessageBox.Show($"Invalid {Path.GetExtension(fileList[0])} file format, only .ets files are supported.",
                        "Invalid format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Menu

        private void createEmptyETSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Yes;
            if (filepath != "")
            {
                result = MessageBox.Show("There is another file already open, are you sure?", "File already open",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (result == DialogResult.Yes)
            {
                BinaryWriter bw = new BinaryWriter(File.Create("ets_new.ETS"));
                bw.Write(new byte[0x10]);
                bw.Close();

                filepath = "ets_new.ETS";
                this.Text = "ETS Tool - ets_new.ETS";
                CreateTable();
                UpdateStatusText("Empty ETS file created", "0 objects");
            }
        }

        private void openETSFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void refreshTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTable();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            this.Text = "ETS Tool";
            filepath = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void duplicateObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DuplicateObject();
        }

        private void duplicateObjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DuplicateObject();
        }
    }
}
