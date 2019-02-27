using EnigmaMachine.UIComponents.Menu;
using System;
using static System.Console;

namespace EnigmaMachine.Setups
{
    public class AdditionalSetups : SetupBase
    {
        public AdditionalSetups(SetupService setupService) : base(setupService)
        {
            MenuItems = new[]
            {
                new MenuItem("Exit", Exit)
            };
        }
        private void Exit()
        {
            WriteLine("Goodbye!");
            Environment.Exit(0);
        }
    }
}
