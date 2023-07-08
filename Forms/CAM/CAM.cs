namespace RE4_PS2_Toolset.Forms.CAM
{
    internal class CAM
    {
        // Header
        public int Magic { get; set; }
        public byte CameraCount1 { get; set; }
        public byte CameraCount2 { get; set; }
        public byte[] HeaderUnk1 { get; set; }

        // Camera entries
        public byte EntryID { get; set; }
        public byte[] EntryUnk1 { get; set; }
        public uint EntryPointerProperties1 { get; set; }
        public uint EntryPointerProperties2 { get; set; }

        // Camera properties 1
        public byte Prop1Active { get; set; }
        public byte Prop1LightGroupIndex { get; set; }
        public byte Prop1Unused1 { get; set; }
        public byte Prop1EntryID { get; set; }
        public int Prop1Padding1 { get; set; }
        public int Prop1Unk1 = 65281;
        public byte[] Prop1Unk2 = new byte[0x14];
        public float Prop1Height { get; set; }
        public float Prop1PositionY { get; set; }
        public int Prop1VerticesCount { get; set; }
        public uint Prop1PointerTriggerzone { get; set; }

        // Camera properties 2
        public byte Prop2Active { get; set; }
        public byte Prop2LightGroupIndex { get; set; }
        public byte Prop2CameraType { get; set; }
        public byte Prop2Unk1 { get; set; }
        public int Prop2Padding1 = 0;
        public int Prop2Unk2 = 1000;
        public byte[] Prop2Unk3 = new byte[0x14];
        public int Prop2DatasetCount { get; set; }
        public uint Prop2PointerPosition { get; set; }
        public uint Prop2PointerDirection { get; set; }
        public uint Prop2PointerPan { get; set; }
        public uint Prop2PointerZoom { get; set; }

        // Camera triggerzones
        public byte[] TriggerzoneBytes { get; set; } // 0x0C * Prop1VerticesCount
        public float TriggerzonePosX { get; set; }
        public float TriggerzonePosY { get; set; }
        public float TriggerzonePosZ { get; set; }

        // Camera position
        public byte[] CameraPosBytes { get; set; } // 0x0C * Prop2DatasetCount
        public float CameraPosX { get; set; }
        public float CameraPosY { get; set; }
        public float CameraPosZ { get; set; }
        public int CameraPosPadding = 32831;

        // Camera direction
        public byte[] CameraDirectionBytes { get; set; } // 0x0C * Prop2DatasetCount
        public float CameraDirectionX { get; set; }
        public float CameraDirectionY { get; set; }
        public float CameraDirectionZ { get; set; }
        public int CameraDirectionPadding = 32831;

        // Camera pan/zoom
        public byte[] CameraPanBytes { get; set; } // 0x0C * Prop2DatasetCount
        public byte[] CameraZoomBytes { get; set; } // 0x0C * Prop2DatasetCount
        public float CameraPan { get; set; }
        public float CameraZoom { get; set; }

        // Camera time duration (for inspection types)
        public ushort[] CameraDuration { get; set; } // 1 short for each dataset count, always starts with 0x00
    }
}
