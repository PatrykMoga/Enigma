using System;
using System.Collections.Generic;
using System.Text;
using ConsoleUI.UIComponents;
using ConsoleUI.UIServiceComponents;
using EnigmaLibrary;

namespace ConsoleUI.Setups
{
    public class ResetPluginsConnection : IUIComponent
    {
        private PluginBoard _pluginBoard;

        public UIComponent Component { get; }

        public ResetPluginsConnection(PluginBoard pluginBoard)
        {
            _pluginBoard = pluginBoard;

            Component = new UIComponent("Reset plugins connection", ResetConnection);            
        }

        private void ResetConnection() => _pluginBoard.Plugins.Clear();
    }
}
