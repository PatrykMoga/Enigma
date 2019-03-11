using ConsoleUI.UIServiceComponents;
using System;

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
