using EnigmaMachine.Machine.Boards;
using EnigmaMachine.Machine.Rotors;
using EnigmaMachine.UIComponents.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace EnigmaMachine.Setup
{
    public class RotorsSetup : IMenuComponent
    {
        public SetupService SetupService { get; }
        public MenuItem[] MenuItems { get; }

        public RotorsSetup(SetupService setupService)
        {
            SetupService = setupService;

            MenuItems = new[]
            {
                new MenuItem("Setup rotors",SetupRotors),
                new MenuItem("Setup rotors positions",SetupRotorsPositions),
                new MenuItem("Reset rotors positions",ResetRotorsPositions),
            };
        }

        private void ResetRotorsPositions() => SetupService.ScramblerBoard.Rotator.ResetPositions();

        public void SetupRotors()
        {
            Clear();
            var names = SetupService.Provider.GetRotorsNames();
            SetupService.ScramblerBoard.Rotor1 = SetRotor(names, 1);
            SetupService.ScramblerBoard.Rotor2 = SetRotor(names, 2);
            SetupService.ScramblerBoard.Rotor3 = SetRotor(names, 3);
            SetupService.ScramblerBoard.Rotator.ResetPositions();
            Clear();
        }

        public void SetupRotorsPositions()
        {
            Write($"Set position of Rotor1: ");
            SetupService.ScramblerBoard.Rotor1.Position = SetRotorPosition();
            Write($"Set position of Rotor2: ");
            SetupService.ScramblerBoard.Rotor2.Position = SetRotorPosition();
            Write($"Set position of Rotor3: ");
            SetupService.ScramblerBoard.Rotor3.Position = SetRotorPosition();
            Clear();
        }

        private byte SetRotorPosition()
        {
            while (true)
            {
                var input = ReadLine();
                if (byte.TryParse(input, out byte possition) && possition < 26)
                {
                    return possition;
                }
                else
                {
                    WriteLine("Wrong try again!");
                }
            }
        }

        private IRotor SetRotor(List<string> names, int number)
        {
            var rotors = $"Availble rotors: {string.Join(", ", names)}";

            Extensions.PrintInLines(rotors);
            WriteLine();
            Write($"Set Rotor{number}: ");

            while (true)
            {
                var input = ReadLine();
                if (names.Contains(input))
                {
                    names.Remove(input);
                    return SetupService.Provider.GetRotor(input);
                }
                else
                {
                    WriteLine("Rotor doesn't exist");
                }
            }
        }
    }
}
