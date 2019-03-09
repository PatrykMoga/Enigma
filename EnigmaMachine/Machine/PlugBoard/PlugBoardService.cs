using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Machine
{
    public class PlugBoardService
    {
        public Dictionary<char, char> PlugBoard { get; set; } = new Dictionary<char, char>();
        
        public string SwapMessage(string message)
        {
            var sb = new StringBuilder();
            foreach (var ch in message.ToUpper())
            {
                sb.Append(SwapChar(ch));
            }
            return sb.ToString();
        }

        public char SwapChar(char ch)
        {
            foreach (var plug in PlugBoard)
            {
                if (plug.Key == ch)
                {
                    return plug.Value;
                }
                if (plug.Value == ch)
                {
                    return plug.Key;
                }
            }
            return ch;
        }
    }
}
