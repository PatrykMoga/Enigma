using EnigmaLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.UIComponents
{
    public class PlugBoardUI : IUIComponent
    {
        public PlugBoard PlugBoard { get; }
        public UIComponent[] UIComponents { get; }

        public PlugBoardUI(PlugBoard plugBoard)
        {
            PlugBoard = plugBoard;
            UIComponents = new[]
            {
                new UIComponent(Show)
            };
        }

        private void Show()
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
