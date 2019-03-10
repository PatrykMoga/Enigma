using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.UIComponents
{
    public class UIService
    {
        public IEnumerable<IUIComponent> UIComponents { get; set; }

        public UIService(IEnumerable<IUIComponent> uiComponents)
        {
            UIComponents = uiComponents;
        }

        public void PrintComponents()
        {
            foreach (var components in UIComponents)
            {
                foreach (var component in components.UIComponents)
                {
                    component.Action();
                }
            }
        }
    }
}
