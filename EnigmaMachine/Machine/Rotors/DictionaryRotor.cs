using EnigmaMachine.Machine.DataRelays;
using System.Collections.Generic;

namespace EnigmaMachine.Machine.Rotors
{
    public class DictionaryRotor : IDictionaryRotor
    {
        public IDataRelay DataRelay { get; }

        public string Name { get; }
        public Dictionary<byte, byte> Values { get; }

        public byte Position { get; set; }
        public byte TurnoverPosition { get; }

        public DictionaryRotor(string name, Dictionary<byte, byte> values, byte turnoverPosition)
        {
            Name = name;
            DataRelay = new DictionaryDataRelay(this);
            TurnoverPosition = turnoverPosition;
            Values = values;
            Position = 0;
        }        
    }
}
