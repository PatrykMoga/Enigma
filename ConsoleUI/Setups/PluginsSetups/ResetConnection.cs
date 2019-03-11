using System;
using System.Collections.Generic;
using System.Text;
using ConsoleUI.UIComponents;
using EnigmaLibrary;

namespace ConsoleUI.Setups
{
    public class ResetConnection : BetterIUIComponent
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
