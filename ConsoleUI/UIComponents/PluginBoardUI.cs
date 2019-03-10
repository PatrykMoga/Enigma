using EnigmaLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.UIComponents
{
    public class PluginBoardUI : IUIComponent
    {
        public PluginBoard PlugBoard { get; }
        public UIComponent[] UIComponents { get; }

        public PluginBoardUI(PluginBoard plugBoard)
        {
            PlugBoard = plugBoard;
            UIComponents = new[]
            {
                new UIComponent(Show)
            };
        }

        private void Show()
        {
            int count = 1;
            var sb = new StringBuilder();
            if (PlugBoard.Plugs.Count > 0)
            {
                foreach (var plug in PlugBoard.Plugs)
                {
                    if (count > 5)
                    {
                        sb.AppendLine();
                        count = 1;
                    }
                    sb.Append($"{plug.Key}-{plug.Value} |");                                      
                    count++;
                }
            }
            else
            {
                sb.Append("No plugins connected");
            }

            Console.WriteLine("Plugins connections:");
            Extensions.PrintInLines(sb.ToString(),25);
            Console.WriteLine();
        }
    }
}
