using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    class Notes
    {
        public void Bla()
        {
            var list3 = new List<int>
            {
                1, 2, 3, 4, 5, 6, -4, 8, 9, 10, 13, 10, -13, 0, 10, -11, -8, 5, -12, -19, -10, -9, -2, -5, -8, -11
            };

            var list2 = new List<int>
            {
                0, 8, 1, 7, 14, 3, 11, 13, 15, -8, 1, -4, 10, 6, -2, -13, 16, -11, 7, -6, -5, 3, -17, -2, -10, -21
            };

            var list1 = new List<int>
            {
                4, 9, 10, 2, 7, 1, -3, 9, 13, 16, 3, 8, 2, 9, 10, -8, 7, 3, 0, -4, -20, -13, -11, -6, -22, -16
            };
        }

        public void RotorsVAlues()
        {
            var rotor3Values = new Dictionary<byte, byte>()
            {
                {0,1},
                {1,3},
                {2,5},
                {3,7},
                {4,9},
                {5,11},
                {6,2},
                {7,15},
                {8,17},
                {9,19},
                {10,23},
                {11,21},
                {12,25},
                {13,13},
                {14,24},
                {15,4},
                {16,8},
                {17,22},
                {18,6},
                {19,0},
                {20,10},
                {21,12},
                {22,20},
                {23,18},
                {24,16},
                {25,14}
            };
            var rotor2Values = new Dictionary<byte, byte>()
            {
                {0,0},
                {1,9},
                {2,3},
                {3,10},
                {4,18},
                {5,8},
                {6,17},
                {7,20},
                {8,23},
                {9,1},
                {10,11},
                {11,7},
                {12,22},
                {13,19},
                {14,12},
                {15,2},
                {16,16},
                {17,6},
                {18,25},
                {19,13},
                {20,15},
                {21,24},
                {22,5},
                {23,21},
                {24,14},
                {25,4}
            };
            var rotor1Values = new Dictionary<byte, byte>()
            {
                {0,4},
                {1,10},
                {2,12},
                {3,5},
                {4,11},
                {5,6},
                {6,3},
                {7,16},
                {8,21},
                {9,25},
                {10,13},
                {11,19},
                {12,14},
                {13,22},
                {14,24},
                {15,7},
                {16,23},
                {17,20},
                {18,18},
                {19,15},
                {20,0},
                {21,8},
                {22,1},
                {23,17},
                {24,2},
                {25,9}
            };
        }

        public byte Switch(byte n)
        {
            switch (n)
            {
                case 0:
                    return 24;
                case 1:
                    return 17;
                case 2:
                    return 20;
                case 3:
                    return 7;
                case 4:
                    return 16;
                case 5:
                    return 18;
                case 6:
                    return 11;
                case 8:
                    return 15;
                case 9:
                    return 23;
                case 10:
                    return 13;
                case 12:
                    return 14;
                case 19:
                    return 25;
                case 21:
                    return 22;
                //case 24:
                //    return 0;
                //case 17:
                //    return 1;
                //case 20:
                //    return 2;
                //case 7:
                //    return 3;
                //case 16:
                //    return 4;
                //case 18:
                //    return 5;                    
                //case 11:
                //    return 6;                   
                //case 15:
                //    return 8;                  
                //case 23:
                //    return 9;                   
                //case 13:
                //    return 10;                   
                //case 14:
                //    return 12;                  
                //case 25:
                //    return 19;                   
                //case 22:
                //    return 21;                  
                default:
                    return 0;
            }
        }
    }
}
