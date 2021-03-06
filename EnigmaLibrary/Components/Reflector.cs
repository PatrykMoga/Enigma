﻿using System.Collections.Generic;
using System.Linq;

namespace EnigmaLibrary.Components
{
    public class Reflector : IReflector
    {
        public string Name { get; set; }
        public Dictionary<char, char> Values { get; set; }

        public char ReflectValue(char c)
        {
            if (Values.ContainsKey(c))
            {
                return Values.First(x => x.Key == c).Value;
            }

            return Values.First(x => x.Value == c).Key;
        }
    }
}
