using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.UIComponents.TopBar;

namespace EnigmaMachine.Machine.Boards
{
    public class ScramblerBoardService : ITopBarComponent
    {
        public ScramblerBoard ScramblerBoard { get; }

        public TopBarItem[] TopBarComponents { get; }

        public ScramblerBoardService(ScramblerBoard scramblerBoard)
        {
            ScramblerBoard = scramblerBoard;

            TopBarComponents = new[]
            {
                new TopBarItem(ScramblerBoardBar)
            };
        }

        private void ScramblerBoardBar()
        {
            var reflector = $"{ScramblerBoard.Reflector.Name}";
            var rotor1 = $"{ScramblerBoard.Rotor1.Name}: {ScramblerBoard.Rotor1.Position}";
            var rotor2 = $"{ScramblerBoard.Rotor2.Name}: {ScramblerBoard.Rotor2.Position}";
            var rotor3 = $"{ScramblerBoard.Rotor3.Name}: {ScramblerBoard.Rotor3.Position}";
            var bar = $"Current: {reflector} | {rotor1} | {rotor2} | {rotor3}";

            Extensions.PrintLines(bar.Length);
            Console.WriteLine(bar);
            Extensions.PrintLines(bar.Length);
            Console.WriteLine();
        }
    }
}
