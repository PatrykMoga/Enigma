using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Reflector
{
    class UKW_B
    {
        public Dictionary<char, char> prop { get; set; }

        public UKW_B()
        {
            prop = new Dictionary<char, char>
            {
                {'A','Y' },
                {'B','R' },
                {'C','U' },
                {'D','H' },
                {'E','Q' },
                {'F','S' },
                {'G','L' },
                {'I','P' },
                {'J','X' },
                {'K','N' },
                {'M','O' },
                {'T','Z' },
                {'V','W' }
            };
        }
    }
}
