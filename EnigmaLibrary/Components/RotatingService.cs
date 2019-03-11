using EnigmaLibrary.Boards;

namespace EnigmaLibrary.Components
{
    public class RotatingService : IRotatingService
    {
        private readonly ScrambleBoard _board;

        public RotatingService(ScrambleBoard board)
        {
            _board = board;
        }

        public void ResetPositions() => _board.Processor1.Rotor.Position = _board.Processor2.Rotor.Position = _board.Processor3.Rotor.Position = 0;

        public void Rotate()
        {
            if (_board.Processor3.Rotor.Position == _board.Processor3.Rotor.TurnoverPosition)
            {
                if (_board.Processor2.Rotor.Position == _board.Processor2.Rotor.TurnoverPosition)
                {
                    _board.Processor1.Rotor.Position++;
                    if (_board.Processor1.Rotor.Position > 25) _board.Processor1.Rotor.Position -= 26;
                }

                _board.Processor2.Rotor.Position++;
                if (_board.Processor2.Rotor.Position > 25) _board.Processor2.Rotor.Position -= 26;
            }

            else if (_board.Processor2.Rotor.Position == _board.Processor2.Rotor.TurnoverPosition)
            {
                _board.Processor2.Rotor.Position++;
                if (_board.Processor2.Rotor.Position > 25) _board.Processor2.Rotor.Position -= 26;

                _board.Processor1.Rotor.Position++;
                if (_board.Processor1.Rotor.Position > 25) _board.Processor1.Rotor.Position -= 26;
            }

            _board.Processor3.Rotor.Position++;
            if (_board.Processor3.Rotor.Position > 25) _board.Processor3.Rotor.Position -= 26;
        }
    }
}