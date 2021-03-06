﻿using System.Collections.Generic;
using System.Text;

namespace EnigmaLibrary.Boards
{
    public class PluginBoard : IPluginBoard
    {
        public Dictionary<char, char> Plugins { get; set; }

        public PluginBoard()
        {
            Plugins = new Dictionary<char, char>();
        }

        public char SwapChar(char ch)
        {
            foreach (var plugin in Plugins)
            {
                if (plugin.Key == ch)
                {
                    return plugin.Value;
                }
                if (plugin.Value == ch)
                {
                    return plugin.Key;
                }
            }
            return ch;
        }
    }
}
