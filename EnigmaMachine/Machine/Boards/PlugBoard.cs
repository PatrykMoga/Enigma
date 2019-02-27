using System.Collections.Generic;

namespace EnigmaMachine.Machine.Boards
{
    public class PlugBoard
    {
        public Dictionary <char,char> Plugs { get; set; }

        public PlugBoard(Dictionary<char,char> plugs)
        {
            Plugs = plugs;
        }
    }
}
