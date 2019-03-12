using ConsoleUI.UIServiceComponents;
using EnigmaLibrary.Boards;
using System;
using System.Text;

namespace ConsoleUI.UIComponents
{
    public class PluginBoardUI : IUIComponent
    {
        private readonly IPluginBoard _plugBoard;
        public UIComponent Component { get; }

        public PluginBoardUI(IPluginBoard plugBoard)
        {
            _plugBoard = plugBoard;
            Component = new UIComponent(Show);          
        }

        private void Show()
        {
            int count = 1;
            var sb = new StringBuilder();
            if (_plugBoard.Plugins.Count > 0)
            {
                foreach (var plug in _plugBoard.Plugins)
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
