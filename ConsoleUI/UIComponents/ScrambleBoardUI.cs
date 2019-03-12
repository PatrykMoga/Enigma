using ConsoleUI.UIServiceComponents;
using EnigmaLibrary.Boards;
using System;

namespace ConsoleUI.UIComponents
{
    public class ScrambleBoardUI : IUIComponent
    {
        private readonly ScrambleBoard _scrambleBoard;
        public UIComponent Component { get; }
        
        public ScrambleBoardUI(ScrambleBoard scramblerBoard)
        {
            _scrambleBoard = scramblerBoard;
            Component = new UIComponent(Show);            
        }

        private void Show()
        {
            var reflector = $"{_scrambleBoard.Reflector.Name}";
            var rotor1 = $"{_scrambleBoard.Processor1.Rotor.Name}: {_scrambleBoard.Processor1.Rotor.Position}";
            var rotor2 = $"{_scrambleBoard.Processor2.Rotor.Name}: {_scrambleBoard.Processor2.Rotor.Position}";
            var rotor3 = $"{_scrambleBoard.Processor3.Rotor.Name}: {_scrambleBoard.Processor3.Rotor.Position}";
            var bar = $"{reflector} | {rotor1} | {rotor2} | {rotor3}";

            Console.WriteLine("Scramble board: ");
            bar.PrintInLines();
            Console.WriteLine();
        }
    }
}
