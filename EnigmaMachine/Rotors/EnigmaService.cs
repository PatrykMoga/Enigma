using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Reflectors;

namespace EnigmaMachine.Rotors
{
    public class EnigmaService
    {
        private readonly RotatingService _rotatingService;

        public Reflector Reflector { get; set; }

        public IRotor Rotor1 { get; set; }
        public IRotor Rotor2 { get; set; }
        public IRotor Rotor3 { get; set; }

        public EnigmaService(IRotor rotor1, IRotor rotor2, IRotor rotor3)
        {
            _rotatingService = new RotatingService();
            Rotor1 = rotor1;
            Rotor2 = rotor2;
            Rotor3 = rotor3;
        }
        public byte PassValue(IRotor rotor, byte value)
        {
            _rotatingService.Rotor = rotor;
            return _rotatingService.PassValue(value);
        }

        public byte ReceiveValue(IRotor rotor, byte value)
        {
            _rotatingService.Rotor = rotor;
            return _rotatingService.ReceiveValue(value);
        }

        public void Rotate()
        {
            if (Rotor3.Position == Rotor3.TurnoverPosition)
            {
                if (Rotor2.Position == Rotor2.TurnoverPosition)
                {
                    Rotor1.Position++;
                    if (Rotor1.Position > 25) Rotor1.Position -= 26;
                }

                Rotor2.Position++;
                if (Rotor2.Position > 25) Rotor2.Position -= 26;
            }

            else if (Rotor2.Position == Rotor2.TurnoverPosition)
            {
                Rotor2.Position++;
                if (Rotor2.Position > 25) Rotor2.Position -= 26;

                Rotor1.Position++;
                if (Rotor1.Position > 25) Rotor1.Position -= 26;
            }

            Rotor3.Position++;
            if (Rotor3.Position > 25) Rotor3.Position -= 26;
        }
    }
}
