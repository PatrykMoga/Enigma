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
            var rotorsRepository = new RotorsRepository();
            var rotorService = new RotorService();

            var one = rotorsRepository.GetRotor("I");
            var two = rotorsRepository.GetRotor("II");
            var three = rotorsRepository.GetRotor("III");
            one.Position = 10;
            two.Position = 4;
            three.Position = 19;

            var reflector = new UKW_B();

            var m = new Enigma(reflector);
            m.Connector = new Connector(one,two,three,rotorService);
            var b = Console.ReadLine();
            var a = m.Encode(b);
            //rlzdlypcwowfbnzcbguczpljbfnbfusumrwlnqzxyejaddkdqlehmvygemhxfdwkffizglvdsfddyaoyxjzrwptunvuhcwmmjagqrwegtvatbichhcfzstnraryuzxhqqxoqwaqabjohgpmmcvkmzjudkyyijanqiqpwzwyspsvkriyqlcxrepgplmqejvmizscsryaumhogltxnkefocyuvnwqfbxohhbecjqyftnfohqumodcysggsdwtwdbwamokrcuh
            Console.WriteLine(a);
        }
    }
}
