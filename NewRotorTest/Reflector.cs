using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NewRotorTest
{
    public class Reflector
    {
        public Dictionary<char, char> Values { get; set; }

        public Reflector()
        {
            Values = new Dictionary<char, char>
            {
                    {'A','Y'},
                    {'B','R'},
                    {'C','U'},
                    {'D','H'},
                    {'E','Q'},
                    {'F','S'},
                    {'G','L'},
                    {'I','P'},
                    {'J','X'},
                    {'K','N'},
                    {'M','O'},
                    {'T','Z'},
                    {'V','W'}
            };
        }

        public char Reflect(char c)
        {
            if (Values.ContainsKey(c))
            {
                return Values.First(x => x.Key == c).Value;
            }

            return Values.First(x => x.Value == c).Key;
        }
    }
}
