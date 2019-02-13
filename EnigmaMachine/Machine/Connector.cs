using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Rotors;

namespace EnigmaMachine.Machine
{
    public class Connector
    {
        private readonly IRotorService _rotorService;
        public IRotor Rotor1 { get; set; }
        public IRotor Rotor2 { get; set; }
        public IRotor Rotor3 { get; set; }

        public Connector(IRotor Rotor1, IRotor Rotor2, IRotor Rotor3, IRotorService rotorService)
        {
            _rotorService = rotorService;
            this.Rotor1 = Rotor1;
            this.Rotor2 = Rotor2;
            this.Rotor3 = Rotor3;
        }
        public byte PassValue(IRotor rotor, byte value)
        {
            _rotorService.Rotor = rotor;
            return _rotorService.PassValue(value);
        }

        public byte ReceiveValue(IRotor rotor, byte value)
        {
            _rotorService.Rotor = rotor;
            return _rotorService.ReceiveValue(value);
        }

        public void Rotate()
        {
            if (Rotor3.Position == Rotor3.KnockPoint)
            {
                if (Rotor2.Position == Rotor2.KnockPoint)
                {
                    Rotor1.Position++;
                    if (Rotor1.Position > 25) Rotor1.Position -= 26;
                }

                Rotor2.Position++;
                if (Rotor2.Position > 25) Rotor2.Position -= 26;
            }

            else if (Rotor2.Position == Rotor2.KnockPoint)
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
