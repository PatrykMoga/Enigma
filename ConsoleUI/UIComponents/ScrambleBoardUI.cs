using EnigmaLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.UIComponents
{
    public class ScrambleBoardUI : IUIComponent
    {
        public UIComponent[] UIComponents { get; }
        public ScrambleBoard ScrambleBoard { get; }

        public ScrambleBoardUI(ScrambleBoard scramblerBoard)
        {
            ScrambleBoard = scramblerBoard;

            UIComponents = new[]
            {
                 new UIComponent(Show)
            };
        }

        private void Show()
        {
            var reflector = $"{ScrambleBoard.Reflector.Name}";
            var rotor1 = $"{ScrambleBoard.Processor1.Rotor.Name}: {ScrambleBoard.Processor1.Rotor.Position}";
            var rotor2 = $"{ScrambleBoard.Processor2.Rotor.Name}: {ScrambleBoard.Processor2.Rotor.Position}";
            var rotor3 = $"{ScrambleBoard.Processor3.Rotor.Name}: {ScrambleBoard.Processor3.Rotor.Position}";
            var bar = $"{reflector} | {rotor1} | {rotor2} | {rotor3}";

            Console.WriteLine("Scramble board: ");
            Extensions.PrintInLines(bar);
            Console.WriteLine();
        }
    }
}
