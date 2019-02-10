using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EnigmaMachine.Rotors
{
    public class Rotor
    {
        private readonly List<int> _values;

        public Rotor(List<int> values)
        {
            _values = values;
            
        }

        public int GetValue(int index)
        {
            var value = index + _values[index];
            if (value > 25)
            {
                value -= 25;
            }
            if (value < 0)
            {
                value += 25;
            }
            return value;
        }

        public int GetIndex(int value)
        {
            //value = 19;
            // 19 = index + value
            for (int i = 0; i < _values.Count; i++)
            {
                var buff = _values[i] + i;
                if (buff == value)
                {
                    return i;
                }
            }

            return 0;
        }

        public void Rotate()
        {
            var buffer = _values[0]; //_values.Last(); 
            _values.Remove(buffer);
            _values.Add(buffer);
            //_values.Insert(0,buffer);
        }

        public List<int> values()
        {
            return _values;
        }

    }
}
