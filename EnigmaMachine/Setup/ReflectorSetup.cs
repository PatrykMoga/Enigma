using EnigmaMachine.Machine.Boards;
using EnigmaMachine.Machine.Rotors;
using EnigmaMachine.UIComponents.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace EnigmaMachine.Setup
{
    public class ReflectorSetup : IMenuComponent
    {
        public SetupService SetupService { get; }

        public MenuItem[] MenuItems { get; }

        public ReflectorSetup(SetupService setupService)
        {
            SetupService = setupService;

            MenuItems = new[]
            {
                new MenuItem("Setup reflector",SetupReflector),
            };
        }

        private void SetupReflector()
        {
            var reflectors = SetupService.Provider.GetReflectorsNames();
            var reflector = $"Availble reflectors: {string.Join(", ", reflectors)}";

            Extensions.PrintInLines(reflector);
            WriteLine();
            Write($"Set reflector: ");

            while (true)
            {
                var input = ReadLine();
                if (reflectors.Contains(input))
                {
                    SetupService.ScramblerBoard.Reflector = SetupService.Provider.GetReflector(input);
                    break;
                }
                else
                {
                    WriteLine("Reflector doesn't exist");
                }
            }
        }
    }
}
