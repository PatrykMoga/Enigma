using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EnigmaMachine.Reflectors
{
    public class Reflector : IReflector
    {
        public string Name { get; }
        public Dictionary<byte, byte> Values { get; }

        public Reflector(string name, Dictionary<byte, byte> values)
        {
            Name = name;
            Values = values;
        }

        public byte ReflectValue(byte n)
        {
            if (Values.ContainsKey(n))
            {
                return Values.First(x => x.Key == n).Value;
            }

            return Values.First(x => x.Value == n).Key;
        }
    }
}
