using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public class Rotor : IRotor
    {
        public IDataRelay DataRelay { get; }

        public string Name { get; }
        public Dictionary<byte, byte> Values { get; }

        public byte Position { get; set; }
        public byte TurnoverPosition { get; }

        public Rotor(string name, Dictionary<byte, byte> values, byte turnoverPosition)
        {
            Name = name;
            DataRelay = new DataRelay(this);
            TurnoverPosition = turnoverPosition;
            Values = values;
            Position = 0;
        }        
    }
}
