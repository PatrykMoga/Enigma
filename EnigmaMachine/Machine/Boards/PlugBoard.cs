using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Machine.Boards
{
    public class PlugBoard
    {
        public Dictionary <char,char> Plugs { get; set; }

        public PlugBoard()
        {
            Plugs = new Dictionary<char, char>();
        }
    }
}
