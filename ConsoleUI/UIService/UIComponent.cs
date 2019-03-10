using System;

namespace ConsoleUI.UIComponents
{
    public class UIComponent
    {
        public Action Action { get; set; }

        public UIComponent(Action action)
        {
            Action = action;
        }
    }
}