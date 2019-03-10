using System.Collections.Generic;
using System.Linq;

namespace EnigmaLibrary
{
    public class DictionaryRotorProcessor
    {
        public DictionaryRotor Rotor { get; set; }

        public byte PassValue(byte index)
        {
            var buff = index + Rotor.Position;

            if (buff > 25) buff -= 26;

            if (buff < 0) buff += 26;

            return Buffer().First(i => i.Key == buff).Value;
        }

        public byte ReceiveValue(byte value)
        {
            var index = Buffer().First(v => v.Value == value).Key;
            var buff = index - Rotor.Position;
            if (buff > 25) buff -= 26;

            if (buff < 0) buff += 26;

            return (byte)(buff);
        }

        private Dictionary<byte, byte> Buffer()
        {
            var buff = new Dictionary<byte, byte>();
            foreach (var item in Rotor.Values)
            {
                var value = item.Value - Rotor.Position;
                if (value > 25) value -= 26;

                if (value < 0) value += 26;

                buff.Add(item.Key, (byte)value);
            }
            return buff;
        }
    }
}