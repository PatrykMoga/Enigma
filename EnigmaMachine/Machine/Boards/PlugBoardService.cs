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

        public PlugBoardService()
        {
            PlugBoard = new PlugBoard();

            TopBarComponents = new[]
            {
                new TopBarItem(PrintPlugBoard)
            };
        }
        
        public void AddPlugConnection(char c, char h)
        {
            if (!(PlugBoard.Plugs.ContainsKey(c) && PlugBoard.Plugs.ContainsKey(h) && PlugBoard.Plugs.ContainsValue(c) && PlugBoard.Plugs.ContainsValue(h)))
            {
                PlugBoard.Plugs.Add(c, h);
            }
            Console.WriteLine("Wronga");
        }

        private void PrintPlugBoard()
        {
            foreach (var plug in PlugBoard.Plugs)
            {
                Console.Write($"{plug.Key}-{plug.Value}");
            }
        }
    }
}
