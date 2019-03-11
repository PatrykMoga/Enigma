using ConsoleUI.UIComponents;
using ConsoleUI.UIServiceComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.Setups
{
    public class ExitCommand : IUIComponent
    {
        public UIComponent Component { get; }

        public ExitCommand()
        {
            Component = new UIComponent("Exit", ExitProgram);
        }

        private void ExitProgram()
        {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
    }
}
