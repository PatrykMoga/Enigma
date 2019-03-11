using System;
using System.Collections.Generic;
using System.Text;
using ConsoleUI.UIComponents;
using EnigmaLibrary;
using static System.Console;

namespace ConsoleUI.Setups
{
    public class SetPositions : BetterIUIComponent
    {
        public UIComponent Component { get; }
        private ScrambleBoard _scramblerBoard;

        public SetPositions(ScrambleBoard scramblerBoard)
        {
            _scramblerBoard = scramblerBoard;            
            Component = new UIComponent("Set rotors positions", Set);
        }

        private void Set()
        {
            Write($"Set position of Rotor1: ");
            _scramblerBoard.Processor1.Rotor.Position = SetPosition();
            Write($"Set position of Rotor2: ");
            _scramblerBoard.Processor2.Rotor.Position = SetPosition();
            Write($"Set position of Rotor3: ");
            _scramblerBoard.Processor3.Rotor.Position = SetPosition();
            Clear();
        }

        private byte SetPosition()
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
                    WriteLine("Enter a number in range 0 and 26!");
                }
            }
        }
    }
}
