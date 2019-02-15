using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Reflectors;

namespace EnigmaMachine.Rotors
{
    public class BoardComponents
    {       
        public Reflector Reflector { get; set; }

        public IRotor Rotor1 { get; set; }
        public IRotor Rotor2 { get; set; }
        public IRotor Rotor3 { get; set; }
      
        public BoardComponents(IRotor rotor1, IRotor rotor2, IRotor rotor3, Reflector reflector)
        {            
            Reflector = reflector;

            Rotor1 = rotor1;
            Rotor2 = rotor2;
            Rotor3 = rotor3;
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
