using EnigmaMachine.UIComponents.TopBar;
using System;
using System.Text;

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
                sb.Append("No plugs connected");
            }
           
            Console.WriteLine("Plugs connections:");          
            Extensions.PrintInLines(sb.ToString());
            Console.WriteLine();
        }
    }
}
