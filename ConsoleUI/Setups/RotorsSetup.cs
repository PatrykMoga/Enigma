using ConsoleUI.UIComponents;
using EnigmaLibrary;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleUI.Setups
{
    public class RotorsSetup : IUIComponent
    {
        public UIComponent[] UIComponents { get; }
        public ScrambleBoard ScramblerBoard { get; }
        public RotatingService RotatingService { get; }
        public MemoryDataProvider DataProvider { get; }

        public RotorsSetup(ScrambleBoard scramblerBoard, RotatingService rotatingService, MemoryDataProvider dataProvider)
        {
            ScramblerBoard = scramblerBoard;
            RotatingService = rotatingService;
            DataProvider = dataProvider;
            UIComponents = new[]
            {
                new UIComponent("Setup rotors",SetupRotors),
                new UIComponent("Setup rotors positions",SetupRotorsPositions),
                new UIComponent("Reset rotors positions",ResetRotorsPositions),
            };
        }

        private void ResetRotorsPositions() => RotatingService.ResetPositions();

        public void SetupRotors()
        {
            Clear();
            var names = DataProvider.GetRotorsNames();
            ScramblerBoard.Processor1.Rotor = SetRotor(names, 1);
            ScramblerBoard.Processor2.Rotor = SetRotor(names, 2);
            ScramblerBoard.Processor3.Rotor = SetRotor(names, 3);
            RotatingService.ResetPositions();
            Clear();
        }

        public void SetupRotorsPositions()
        {
            Write($"Set position of Rotor1: ");
            ScramblerBoard.Processor1.Rotor.Position = SetRotorPosition();
            Write($"Set position of Rotor2: ");
            ScramblerBoard.Processor2.Rotor.Position = SetRotorPosition();
            Write($"Set position of Rotor3: ");
            ScramblerBoard.Processor3.Rotor.Position = SetRotorPosition();
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

        private DictionaryRotor SetRotor(List<string> names, int number)
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
                    return DataProvider.GetRotor(input);
                }
                else
                {
                    WriteLine("Rotor doesn't exist");
                }
            }
        }
    }
}
