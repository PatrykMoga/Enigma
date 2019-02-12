using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    class II : IRotor
    {
        public Dictionary<byte, byte> Values { get; }
        public byte Position { get; set; }

        public II(byte possition)
        {
            Position = possition;
            Values = new Dictionary<byte, byte>
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
        }

        public void Rotate()
        {
            throw new NotImplementedException();
        }
    }
}
