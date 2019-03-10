using System.Collections.Generic;

namespace EnigmaLibrary
{
    public class DictionaryRotor
    {
        public string Name { get; set; }
        public Dictionary<byte, byte> Values { get; set; }
        public byte Position { get; set; } = 0;
        public byte TurnoverPosition { get; set; }
    }
}