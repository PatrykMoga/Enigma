using System.Collections.Generic;

namespace EnigmaLibrary.Boards
{
    public interface IPluginBoard
    {
        Dictionary<char, char> Plugins { get; set; }

        char SwapChar(char ch);
        string SwapMessage(string message);
    }
}