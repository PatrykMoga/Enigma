using EnigmaLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.UIComponents
{
    public class ScramblerBoardUI : IUIComponent
    {
        public UIComponent[] UIComponents { get; }
        public ScramblerBoard ScramblerBoard { get; }

        public ScramblerBoardUI(ScramblerBoard scramblerBoard)
        {
            ScramblerBoard = scramblerBoard;

            UIComponents = new[]
            {
                 new UIComponent(Show)
            };
        }

        private void Show()
        {
            var reflector = $"{ScramblerBoard.Reflector.Name}";
            var rotor1 = $"{ScramblerBoard.Processor1.Rotor.Name}: {ScramblerBoard.Processor1.Rotor.Position}";
            var rotor2 = $"{ScramblerBoard.Processor2.Rotor.Name}: {ScramblerBoard.Processor2.Rotor.Position}";
            var rotor3 = $"{ScramblerBoard.Processor3.Rotor.Name}: {ScramblerBoard.Processor3.Rotor.Position}";
            var bar = $"Current: {reflector} | {rotor1} | {rotor2} | {rotor3}";

            Extensions.PrintInLines(bar);
            Console.WriteLine();
        }
    }
}
