using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    class I : IRotor
    {
        public Dictionary<byte, byte> Values { get; }
        public byte Position { get; set; }

        public I(byte possition)
        {
            Position = possition;
            Values = new Dictionary<byte, byte>
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

        public void Rotate()
        {
            throw new NotImplementedException();
        }
    }
}
