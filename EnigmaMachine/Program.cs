using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnigmaMachine.Rotors;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Machine;

namespace EnigmaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //var rotorService = new RotorService <I>();           
            
            //var rotor1 = new I(0);
            //var rotor2 = new II(0);
            //var rotor3 = new III(0);

            
            //var two = new Connector(rotor2, rotorService);
            //var one = new Connector(rotor1, rotorService);
            //var three = new Connector(rotor3, rotorService);




            var reflector = new UKW_B();


            //var m = new Kupa(one,two,three, reflector);
            //m.Encode("BARBARA");
           
        }     
    }
}
