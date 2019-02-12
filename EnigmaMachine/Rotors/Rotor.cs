using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public class Rotor : IRotor
    {
        public Dictionary<byte, byte> Values { get; }
        public byte Position { get; set; }

        public Rotor(Dictionary<byte,byte> values)
        {
            Values = values;
            Position = 0;
        }

        public void Rotate() => Position++;
        
    }
}
