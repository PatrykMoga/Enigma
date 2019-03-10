using ConsoleUI.UIComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.Setups
{
    public class AdditionalSetups : IUIComponent
    {
        public UIComponent[] UIComponents { get; }

        public AdditionalSetups()
        {
            UIComponents = new[]
            {
                new UIComponent("Exit",Exit)
            };
        }

        private void Exit()
        {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
    }
}
