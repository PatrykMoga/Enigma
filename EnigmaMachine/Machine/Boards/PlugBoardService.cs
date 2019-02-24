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
        
        public void AddPlugConnection(char c, char h)
        {
            var p = PlugBoard.Plugs;
            if (!(p.ContainsKey(c) && p.ContainsKey(h) && p.ContainsValue(c) && p.ContainsValue(h)))
            {
                p.Add(c, h);
            }
            else
            {
                Console.WriteLine("Wronga");
            }         
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
                sb.Append("No plugs pluged");
            }
           
            Console.WriteLine("Plugs connections:");
            Extensions.PrintLines(sb.Length);
            Console.WriteLine(sb.ToString());
            Extensions.PrintLines(sb.Length);
            Console.WriteLine();
        }
    }
}
