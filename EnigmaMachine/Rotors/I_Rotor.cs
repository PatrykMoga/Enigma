using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    class I_Rotor
    {
        public Dictionary<int,char> MyProperty { get; set; }
        public int r { get; set; }

        public I_Rotor()
        {
            MyProperty = new Dictionary<int, char>
            {
                {1,'E' },
                {2,'K' },
                {3,'M' },
                {4,'F' },
                {5,'L' },
                {6,'G' },
                {7,'D' },
                {8,'Q' },
                {9,'V' },
                {10,'Z' },
                {11,'N' },
                {12,'T' },
                {13,'O' },
                {14,'W' },
                {15,'Y' },
                {16,'H' },
                {17,'X' },
                {18,'U' },
                {19,'S' },
                {20,'P' },
                {21,'A' },
                {22,'I' },
                {23,'B' },
                {24,'R' },
                {25,'C' },
                {26,'J' }
            };
        }
    }
}
