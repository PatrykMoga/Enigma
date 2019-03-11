using ConsoleUI.UIServiceComponents;
using EnigmaLibrary;
using System;
using System.Text;

namespace ConsoleUI.UIComponents
{
    public class PluginBoardUI : IUIComponent
    {
        public IPluginBoard PlugBoard { get; }
        public UIComponent Component { get; }

        public PluginBoardUI(IPluginBoard plugBoard)
        {
            PlugBoard = plugBoard;
            Component = new UIComponent(Show);          
        }

        private void Show()
        {
            int count = 1;
            var sb = new StringBuilder();
            if (PlugBoard.Plugins.Count > 0)
            {
                foreach (var plug in PlugBoard.Plugins)
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
            sb.ToString().PrintInLines(25);
            Console.WriteLine();
        }
    }
}
