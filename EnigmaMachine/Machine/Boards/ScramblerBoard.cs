﻿using EnigmaMachine.Machine.Reflectors;
using EnigmaMachine.Machine.Rotator;
using EnigmaMachine.Machine.Rotors;

namespace EnigmaMachine.Machine.Boards
{
    public class ScramblerBoard 
    {
        public RotatorService Rotator { get; }
        public IReflector Reflector { get; set; }

        public IRotor Rotor1 { get; set; }
        public IRotor Rotor2 { get; set; }
        public IRotor Rotor3 { get; set; }

        public ScramblerBoard(IRotor rotor1, IRotor rotor2, IRotor rotor3, IReflector reflector)
        {
            Rotator = new RotatorService(this);
            Reflector = reflector;

            Rotor1 = rotor1;
            Rotor2 = rotor2;
            Rotor3 = rotor3;
        }       
    }
}
