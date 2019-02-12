using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    class III : IRotor
    {
        public Dictionary<byte, byte> Values { get; }
        public byte Position { get; set; }

        public III(byte possition)
        {
            Position = possition;
            Values = new Dictionary<byte, byte>
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
        }

        public void Rotate()
        {
            throw new NotImplementedException();
        }
    }
}
