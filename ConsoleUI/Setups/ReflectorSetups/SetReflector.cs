﻿using ConsoleUI.UIComponents;
using ConsoleUI.UIServiceComponents;
using EnigmaLibrary;
using static System.Console;

namespace ConsoleUI.Setups
{
    public class SetReflector : IUIComponent
    {
        public UIComponent Component { get; }
        private ScrambleBoard _board;
        private MemoryDataProvider _dataProvider;

        public SetReflector(ScrambleBoard board, MemoryDataProvider dataProvider)
        {
            Component = new UIComponent("Set reflector", Set);
            _board = board;
            _dataProvider = dataProvider;
        }

        private void Set()
        {
            Clear();
            var reflectors = _dataProvider.GetReflectorsNames();
            var reflector = $"Availble reflectors: {string.Join(", ", reflectors)}";

            Extensions.PrintInLines(reflector);
            WriteLine();
            Write($"Set reflector: ");

            while (true)
            {
                var input = ReadLine();
                if (reflectors.Contains(input))
                {
                    _board.Reflector = _dataProvider.GetReflector(input);
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
