using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EnigmaMachine.Rotors
{
    public class RotorS
    {
        private readonly List<char> _list;

        public RotorS(List<char> list)
        {
            _list = list;
        }

        public char GetValue(byte index)
        {
            return _list[index];
        }

        public byte GetIndex(byte value)
        {
            return (byte)_list.FindIndex(i => i == value);
        }

        public void Rotate()
        {
            var buffer = _list[0];
            _list.Remove(buffer);
            _list.Add(buffer);
            //_list.Insert(0,buffer);
        }

        public List<char> GetList()
        {
            return _list;
        }
    }
}
