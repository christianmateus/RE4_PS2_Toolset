using System.Collections.Generic;

namespace RE4_PS2_Toolset.Forms.ETS
{
    public class ETS
    {
        public int ObjectQuantity { get; set; }
        public uint ScaleX { get; set; }
        public uint ScaleY { get; set; }
        public uint ScaleZ { get; set; }
        public float RotationX { get; set; }
        public float RotationY { get; set; }
        public float RotationZ { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public uint Padding { get; set; }
        public ushort ObjectID { get; set; }
        public ushort Index { get; set; }


        public Dictionary<uint, string> ETSList = new Dictionary<uint, string>()
        {
            {0, "Window" },
            {1, "Small Box"},
            {2, "Large Box"},
            {3, "Wooden Door 1"},
            {4, "Movable Drawer"},
            {5, "Bookshelf"},
            {6, "Ladder (Small)"},
            {7, "Wooden Barricade"},
            {8, "Ladder (Big)}" },
            {9, "Wooden Gate"},
            {10,"Lantern w/ chains" },
            {11, "Lantern (Ashley)"},
            {12, "Unknown"},
            {13, "Rusted Metal Door"},
            {14, "Lever"},
            {15, "No-Knob Gate"},
            {16, "Lantern"},
            {17, "Barrel"},
            {18, "Explosive Barrel"},
            {19, "Wooden Door 2"},
            {20, "Torch (Top part)"},
            {21, "Large Movable Box"},
            {22, "Metal Door 1"},
            {23, "Metal Door 2"},
            {24, "Castle Door 1"},
            {25, "Torch (Top part)"},
            {26, "Medalion"},
            {27, "Iron Gate"},
            {28, "Unknown"},
            {29, "Big Window"},
            {30, "Barrel (laid down)"},
            {31, "Bird Nest"},
            {32, "Castle Door 2"},
            {33, "Castle Door 3"},
            {34, "Wooden Door 3"},
            {35, "Cell Gate"},
            {36, "Dungeon Metal Door"},
            {37, "Glass (bookshelf)"},
            {38, "Metal Gate"},
            {39, "Big Wooden Door"},
            {40, "not used"},
            {41, "Glass"},
            {42, "Metal Door 3"},
            {43, "Metal Door 4"},
            {44, "Window"},
            {45, "Explosive Barrel"},
            {46, "Small Vase"},
            {47, "Large Vase"},
            {48, "Knight Statue"},
            {49, "Cell Door"},
            {50, "Door with Insignia"},
            {51, "Metal Door 5"},
            {52, "Metal Door 6"},
            {53, "Window"},
            {54, "Unknown"},
            {55, "Cell Gate 2"},
            {56, "Unknown"},
            {57, "Prison Door"},
            {58, "Blue Gate"},
            {59, "Castle Door 3"},
            {60, "Cylinder Tank"},
            {61, "Castle Door 4"},
            {62, "Metal Door 7"},
            {63, "Castle Door 5"},
            {64, "Curved Wooden Door"},
            {65, "White Metal Door"} ,
            {66, "Piece of Wood"} ,
            {67, "Modern Door"} ,
            {68, "Piece of Wood"} ,
            {69, "Garden Gate"} ,
            {70, "Door w/ Glass"} ,
            {71, "Island Gate"} ,
            {72, "Glass"} ,
            {73, "Island Door 1"} ,
            {74, "Window"} ,
            {75, "Laboratory Door"} ,
            {76, "U3 gates"} ,
            {77, "Island Door 2"} ,
            {78, "Keycard Door"} ,
            {79, "Laboratory Door"} ,
            {80, "Laboratory Window"} ,
            {81, "Laboratory Glass"} ,
            {82, "Laboratory Cylinder S"} ,
            {83, "Laboratory Cylinder L"} ,
            {84, "Window"} ,
            {85, "Window"} ,
            {86, "Glass"} ,
            {87, "Glass"} ,
            {88, "Window"},
            {89, "Red Iron Door"},
            {90, "Window"},
            {91, "Unknown"},
            {92, "Unknown"},
            {93, "Small Window"},
            {94, "Small Window"},
            {95, "Small Window"},
            {96, "Small Window"},
            {97, "Automatic Door"},
            {98, "Cell Door"},
            {99, "Island Metal Door"},
            {100,"Glass"},
            {101,"Glass"},
            {102,"Dragon Statue"},
            {103,"Old Gate"},
            {104,"Barn Gate (left)"},
            {105,"Barn Gate (right)"},
        };
    }

}
