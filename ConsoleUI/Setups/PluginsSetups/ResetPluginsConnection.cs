using ConsoleUI.UIServiceComponents;
using EnigmaLibrary;

namespace ConsoleUI.Setups
{
    public class ResetPluginsConnection : IUIComponent
    {
        private readonly IPluginBoard _pluginBoard;
        public UIComponent Component { get; }

        public ResetPluginsConnection(IPluginBoard pluginBoard)
        {
            _pluginBoard = pluginBoard;
            Component = new UIComponent("Reset plugins connection", ResetConnection);            
        }

        private void ResetConnection() => _pluginBoard.Plugins.Clear();
    }
}
