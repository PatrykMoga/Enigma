using ConsoleUI.UIServiceComponents;
using EnigmaLibrary.Boards;
using EnigmaLibrary.Components;
using EnigmaLibrary.Repository;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleUI.Setups
{
    public class SetRotors : IUIComponent
    {
        private readonly ScrambleBoard _scramblerBoard;
        private readonly IRotatingService _rotatingService;
        private readonly IDataProvider _dataProvider;
        public UIComponent Component { get; }

        public SetRotors(ScrambleBoard scramblerBoard, IRotatingService rotatingService, IDataProvider dataProvider)
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

        private Rotor SetRotor(IList<string> names, int number)
        {
            var rotors = $"Availble rotors: {string.Join(", ", names)}";

            rotors.PrintInLines();
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
