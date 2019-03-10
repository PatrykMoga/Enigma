using System.Collections.Generic;
using System.Linq;

namespace EnigmaLibrary
{
    public class RotatingService
    {
        public ScramblerBoard Board { get; }

        public RotatingService(ScramblerBoard board)
        {
            Board = board;
        }

        public void ResetPositions() => Board.Processor1.Rotor.Position = Board.Processor2.Rotor.Position = Board.Processor3.Rotor.Position = 0;

        public void Rotate()
        {
            if (Board.Processor3.Rotor.Position == Board.Processor3.Rotor.TurnoverPosition)
            {
                if (Board.Processor2.Rotor.Position == Board.Processor2.Rotor.TurnoverPosition)
                {
                    Board.Processor1.Rotor.Position++;
                    if (Board.Processor1.Rotor.Position > 25) Board.Processor1.Rotor.Position -= 26;
                }

                Board.Processor2.Rotor.Position++;
                if (Board.Processor2.Rotor.Position > 25) Board.Processor2.Rotor.Position -= 26;
            }

            else if (Board.Processor2.Rotor.Position == Board.Processor2.Rotor.TurnoverPosition)
            {
                Board.Processor2.Rotor.Position++;
                if (Board.Processor2.Rotor.Position > 25) Board.Processor2.Rotor.Position -= 26;

                Board.Processor1.Rotor.Position++;
                if (Board.Processor1.Rotor.Position > 25) Board.Processor1.Rotor.Position -= 26;
            }

            Board.Processor3.Rotor.Position++;
            if (Board.Processor3.Rotor.Position > 25) Board.Processor3.Rotor.Position -= 26;
        }
    }
}