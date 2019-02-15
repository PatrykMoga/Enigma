using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public class Rotor : IRotor
    {
        public Dictionary<byte, byte> Values { get; }

        public byte Position { get; set; }
        public byte TurnoverPosition { get; }

        public Rotor(Dictionary<byte, byte> values, byte turnoverPosition)
        {
            TurnoverPosition = turnoverPosition;
            Values = values;
            Position = 0;
        }
    }
}
