using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.UIComponents
{
    public class UIService
    {
        public List<UIComponent> UIComponents { get; set; }

        public UIService()
        {
            UIComponents = new List<UIComponent>();
        }

        public void PrintComponents()
        {
            foreach (var component in UIComponents)
            {
                component.Action();
            }
        }

        public void AddComponent(IUIComponent component)
        {
            foreach (var item in component.UIComponents)
            {
                UIComponents.Add(item);
            }
        }
    }
}
