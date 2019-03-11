using ConsoleUI.UIComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.Setups
{
    public class Exit : BetterIUIComponent
    {
        public UIComponent Component { get; }

        public Exit()
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
