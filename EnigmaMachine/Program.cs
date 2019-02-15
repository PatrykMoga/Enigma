using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnigmaMachine.Rotors;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Machine;
using EnigmaMachine.Repository;
using EnigmaMachine.Setup;

namespace EnigmaMachine
{
    class Program
    {
        static void Main()
        {            
            var enigma = new Enigma();
            enigma.Initialize();
        }
    }
}
