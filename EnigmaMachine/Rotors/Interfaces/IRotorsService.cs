using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public interface IRotorsService
    {
        IRotor Rotor1 { get; set; }
        IRotor Rotor2 { get; set; }
        IRotor Rotor3 { get; set; }

        byte PassValue(IRotor rotor, byte value);
        byte ReceiveValue(IRotor rotor, byte value);
        void Rotate();
    }
}
