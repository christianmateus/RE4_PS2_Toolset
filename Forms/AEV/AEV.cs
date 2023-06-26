namespace RE4_PS2_Toolset.Forms.AEV
{
    public class AEV
    {
        // Header
        public uint Magic = 5653825;
        public byte unk1 { get; set; }
        public byte unk2 { get; set; }
        public byte EventCount { get; set; }

        // Event Main Config
        public uint PointerToNext { get; set; }
        public byte unk3 { get; set; }
        public byte AreaHitType { get; set; }
        public short Padding { get; set; }
        public float PosY { get; set; }
        public float Height { get; set; }
        public float PosX1 { get; set; }
        public float PosZ1 { get; set; }
        public float PosX2 { get; set; }
        public float PosZ2 { get; set; }
        public float PosX3 { get; set; }
        public float PosZ3 { get; set; }
        public float PosX4 { get; set; }
        public float PosZ4 { get; set; }
        public byte Active { get; set; } // 2=inactive; 3=active
        public byte EventType { get; set; }
        public byte Index { get; set; }
        public byte HitType { get; set; }
        public byte TriggerType { get; set; }
        public byte TargetType { get; set; }
        public byte[] Padding2 = new byte[10];
        public byte Priority { get; set; }
        public byte Definition1 { get; set; }
        public byte Definition2 { get; set; }
        public byte Definition3 { get; set; }
        public byte HitAngle { get; set; }
        public byte OpenAngle { get; set; }
        public byte ScreenText { get; set; }
        public byte[] Padding3 = new byte[0x15];

        // Event 1 Config
        public float Type1PosX { get; set; }
        public float Type1PosY { get; set; }
        public float Type1PosZ { get; set; }
        public float Type1Rotation { get; set; }
        public byte Type1Stage { get; set; }
        public byte Type1Room { get; set; }
        public byte Type1KeyID { get; set; }
        public byte Type1LockFlag { get; set; }
        public uint Type1padding { get; set; }
        public byte Type1Checkpoint { get; set; }
        public byte Type1KeySFX { get; set; }
        public byte Type1OpenSFX { get; set; }
        public byte Type1FadeEffect { get; set; }

        // Event 4 Config
        public byte Type4ID { get; set; }
        public byte Type4Action { get; set; }
        public uint Type4Number { get; set; }

        // Event 5 Config
        public ushort Type5MessageType { get; set; }
        public ushort Type5MessageNumber { get; set; }
        public byte Type5CameraIndex { get; set; }
        public byte Type5SoundOrigin { get; set; } // Room: 0, Player: 1
        public byte Type5SoundIndex { get; set; }

        // Event A Config
        public uint Type10DamageTimer { get; set; }
        public byte Type10DamageType { get; set; }
        public byte Type10DamageFlag { get; set; } // Die: 1; Angle Set: 2
        public short Type10DamageUnused { get; set; }
        public uint Type10DamageAmount { get; set; }
        public byte Type10DamageAngle { get; set; }

        // Event 0x10 Config
        public float Type16LadderPositionX { get; set; }
        public float Type16LadderPositionY { get; set; }
        public float Type16LadderPositionZ { get; set; }
        public float Type16LadderAngle { get; set; }
        public uint Type16LadderSteps { get; set; }
        public byte Type16LadderCamStart { get; set; }
        public byte Type16LadderCamEnd { get; set; }
        public byte Type16LadderCam3 { get; set; }
        public byte Type16LadderCam4 { get; set; }

        // Event 0x11 Config
        public uint Type17ItemID { get; set; }

        // Event 0x12 Config
        public byte Type18HideType { get; set; }
        public byte Type18HidePositionSet { get; set; }
        public byte Type18HideAreaSet { get; set; }
        public byte Type18HideActive { get; set; }
        public float Type18HidePositionX1 { get; set; }
        public float Type18HidePositionZ1 { get; set; }
        public float Type18HidePositionX2 { get; set; }
        public float Type18HidePositionZ2 { get; set; }
        public float Type18HidePositionX3 { get; set; }
        public float Type18HidePositionZ3 { get; set; }
        public float Type18HidePositionX4 { get; set; }
        public float Type18HidePositionZ4 { get; set; }
        public float Type18HidePositionY { get; set; }
        public float Type18HidePositionHeight { get; set; }
        public float Type18HideAreaX { get; set; }
        public float Type18HideAreaY { get; set; }
        public float Type18HideAreaZ { get; set; }

        // Event 0x15 Config
        public float Type21GrappleAreaX { get; set; }
        public float Type21GrappleAreaY { get; set; }
        public float Type21GrappleAreaZ { get; set; }
        public float Type21GrappleDestinationX { get; set; }
        public float Type21GrappleDestinationY { get; set; }
        public float Type21GrappleDestinationZ { get; set; }
        public float Type21GrappleAngle { get; set; }
        public byte Type21GrappleCamera1 { get; set; }
        public byte Type21GrappleCamera2 { get; set; }
        public byte Type21GrappleCamera3 { get; set; }
        public byte Type21GrappleCamera4 { get; set; }


        public enum EventTypes
        {
            General = 0x00,
            DoorTeleport = 0x01,
            Cutscene = 0x02,
            EnemyGroupTrigger = 0x04,
            Message = 0x05,
            Save = 0x08,
            Damage = 0x0A,
            TemporaryColision = 0x0B,
            Crouch = 0x0E,
            LadderClimb = 0x10,
            ItemDependent = 0x11,
            HideAshley = 0x12,
            Elevators = 0x14,
            GrappleGun = 0x15,
        }

        public enum DamageType
        {
            NoHit = 0,
            Fire = 1,
            Electricity = 2,
            EnvLight = 3,
            EnvFire = 4,
            GrenadeBlast = 5,
            Push = 6
        }
    }
}
