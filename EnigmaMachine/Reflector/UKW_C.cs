using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Reflector
{
    class UKW_C
    {
        public Dictionary<char, char> prop { get; set; }

        public UKW_C()
        {
            prop = new Dictionary<char, char>
            {
                {'A','F' },
                {'B','V' },
                {'C','P' },
                {'D','J' },
                {'E','I' },
                {'G','O' },
                {'H','Y' },
                {'K','R' },
                {'L','Z' },
                {'M','X' },
                {'N','W' },
                {'Q','T' },
                {'S','U' }
            };
        }
    }
}
