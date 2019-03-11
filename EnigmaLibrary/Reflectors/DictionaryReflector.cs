﻿using System.Collections.Generic;
using System.Linq;

namespace EnigmaLibrary
{
    public class DictionaryReflector : IReflector
    {
        public string Name { get; set; }
        public Dictionary<byte, byte> Values { get; set; }

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