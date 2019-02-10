using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EnigmaMachine.Rotors
{
    public class RotorService
    {
        private readonly Dictionary<byte,byte> _values;
        public byte Position { get; set; }

        public RotorService(Dictionary<byte,byte> values, byte position)
        {
            _values = values;
            Position = position;
        }

        public byte GetValueByIndex(byte index)
        {
            var value = Rotor().First(i => i.Key == (index + Position)).Value;          
            return (byte)value;
        }

        public byte GetIndexByValue(byte value)
        {
            var index = Rotor().First(v => v.Value == value).Key;
            var buff = index - Position;
            if (buff > 25)
            {
                buff -= 26;
            }
            if (buff < 0)
            {
                buff += 26;
            }
            
            return (byte)(buff);
        }

        public Dictionary<byte,byte> Rotor()
        {
            var buff = new Dictionary<byte, byte>();
            foreach (var item in _values)
            {               
                var value = item.Value - Position;
                if (value > 25)
                {
                    value -= 26;
                }
                if (value < 0)
                {
                    value += 26;
                }

                buff.Add((byte)item.Key, (byte)value);
            }
            return buff;
        }
      
    }
}
