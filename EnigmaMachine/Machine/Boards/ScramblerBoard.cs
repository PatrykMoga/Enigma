using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Reflectors;

namespace EnigmaMachine.Rotors
{
    public class ScramblerBoard
    {
        public Rotator Rotator { get; }
        public IReflector Reflector { get; set; }

        public IRotor Rotor1 { get; set; }
        public IRotor Rotor2 { get; set; }
        public IRotor Rotor3 { get; set; }
      
        public ScramblerBoard(IRotor rotor1, IRotor rotor2, IRotor rotor3, IReflector reflector)
        {
            Rotator = new Rotator(this);
            Reflector = reflector;

            Rotor1 = rotor1;
            Rotor2 = rotor2;
            Rotor3 = rotor3;
        }       
    }
}
