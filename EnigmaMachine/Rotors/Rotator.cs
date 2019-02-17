using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public class Rotator
    {
        private readonly ScramblerBoard _board;

        public Rotator(ScramblerBoard board) => _board = board;

        public void Rotate()
        {
            if (_board.Rotor3.Position == _board.Rotor3.TurnoverPosition)
            {
                if (_board.Rotor2.Position == _board.Rotor2.TurnoverPosition)
                {
                    _board.Rotor1.Position++;
                    if (_board.Rotor1.Position > 25) _board.Rotor1.Position -= 26;
                }

                _board.Rotor2.Position++;
                if (_board.Rotor2.Position > 25) _board.Rotor2.Position -= 26;
            }

            else if (_board.Rotor2.Position == _board.Rotor2.TurnoverPosition)
            {
                _board.Rotor2.Position++;
                if (_board.Rotor2.Position > 25) _board.Rotor2.Position -= 26;

                _board.Rotor1.Position++;
                if (_board.Rotor1.Position > 25) _board.Rotor1.Position -= 26;
            }

            _board.Rotor3.Position++;
            if (_board.Rotor3.Position > 25) _board.Rotor3.Position -= 26;
        }
    }
}
