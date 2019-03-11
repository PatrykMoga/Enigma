using System;
using System.Collections.Generic;
using System.Text;
using ConsoleUI.UIComponents;
using ConsoleUI.UIServiceComponents;
using EnigmaLibrary;

namespace ConsoleUI.Setups
{
    public class ResetConnection : IUIComponent
    {
        private PluginBoard _pluginBoard;
        public UIComponent Component { get; }

        public ResetConnection(PluginBoard pluginBoard)
        {
            _pluginBoard = pluginBoard;
            Component = new UIComponent("Reset plugins connection", Reset);            
        }

        private void Reset() => _pluginBoard.Plugins.Clear();
    }
}
