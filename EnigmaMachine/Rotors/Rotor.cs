using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public class Rotor : IRotor
    {
        public Dictionary<byte, byte> Values { get; }
        public byte Position { get; set; }

        public byte KnockPoint { get;}

        public Rotor(Dictionary<byte, byte> values, byte rotateValue)
        {
            KnockPoint = rotateValue;
            Values = values;
            Position = 0;
        }
    }
}
