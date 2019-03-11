using ConsoleUI.UIComponents;
using EnigmaLibrary;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
using ConsoleUI.UIServiceComponents;

namespace ConsoleUI.Setups
{
    public class SetRotors : IUIComponent
    {
        public UIComponent Component { get; }
        private ScrambleBoard _scramblerBoard;
        private RotatingService _rotatingService;
        private MemoryDataProvider _dataProvider;

        public SetRotors(ScrambleBoard scramblerBoard, RotatingService rotatingService, MemoryDataProvider dataProvider)
        {
            _scramblerBoard = scramblerBoard;
            _rotatingService = rotatingService;
            _dataProvider = dataProvider;
            Component = new UIComponent("Set rotors", Set);          
        }
        private void Set()
        {
            Clear();
            var names = _dataProvider.GetRotorsNames();
            _scramblerBoard.Processor1.Rotor = SetRotor(names, 1);
            _scramblerBoard.Processor2.Rotor = SetRotor(names, 2);
            _scramblerBoard.Processor3.Rotor = SetRotor(names, 3);
            _rotatingService.ResetPositions();
            Clear();
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
                    return _dataProvider.GetRotor(input);
                }
                else
                {
                    WriteLine("Rotor doesn't exist");
                }
            }
        }
    }
}
