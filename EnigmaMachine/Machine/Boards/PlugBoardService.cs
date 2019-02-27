using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.UIComponents.TopBar;

namespace EnigmaMachine.Machine.Boards
{
    public class PlugBoardService : ITopBarComponent
    {
        public PlugBoard PlugBoard { get; set; }
        public TopBarItem[] TopBarComponents { get; }

        public PlugBoardService(PlugBoard plugBoard)
        {
            PlugBoard = plugBoard;

            TopBarComponents = new[]
            {
                new TopBarItem(ShowPlugBoard)
            };
        }
        
        public string ProvidePlugs(string message)
        {
            var sb = new StringBuilder();
            foreach (var ch in message.ToUpper())
            {
                sb.Append(SwapChars(ch));
            }
            return sb.ToString();
        }

        public char SwapChars(char ch)
        {
            foreach (var plug in PlugBoard.Plugs)
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

        private void ShowPlugBoard()
        {
            var sb = new StringBuilder();
            if (PlugBoard.Plugs.Count > 0)
            {
                foreach (var plug in PlugBoard.Plugs)
                {
                    sb.Append($"{plug.Key}-{plug.Value} |");
                }
            }
            else
            {
                sb.Append("No plugs plugegd");
            }
           
            Console.WriteLine("Plugs connections:");
            Extensions.PrintLines(sb.Length);
            Console.WriteLine(sb.ToString());
            Extensions.PrintLines(sb.Length);
            Console.WriteLine();
        }
    }
}
