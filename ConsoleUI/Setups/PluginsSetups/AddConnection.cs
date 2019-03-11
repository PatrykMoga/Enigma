using ConsoleUI.UIComponents;
using EnigmaLibrary;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
using ConsoleUI.UIServiceComponents;

namespace ConsoleUI.Setups
{
    class AddConnection : IUIComponent
    {
        private PluginBoard _pluginBoard;
        public UIComponent Component { get; }

        public AddConnection(PluginBoard pluginBoard)
        {
            _pluginBoard = pluginBoard;
            Component = new UIComponent("Add plugin connection", SetupConnection);
        }

        private void SetupConnection()
        {
            Clear();
            Write("Enter the connection in this format (XY): ");
            var p = _pluginBoard.Plugins;
            var input = ReadLine();
            input = input.ToUpper();
            AddPlugin(input[0], input[1]);
        }

        private void AddPlugin(char c, char h)
        {
            var p = _pluginBoard.Plugins;
            if (!p.ContainsKey(c) && !p.ContainsKey(h) && !p.ContainsValue(c) && !p.ContainsValue(h))
            {
                p.Add(c, h);
            }
            else
            {
                WriteLine("Plugin is already connected or input is in wrong format");
            }
        }
    }
}
