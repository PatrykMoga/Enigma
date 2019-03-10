using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaLibrary
{
    public class PluginBoard
    {
        public Dictionary<char, char> Plugs { get; set; } = new Dictionary<char, char>(); //TEMP
        
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
            foreach (var plug in Plugs)
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
