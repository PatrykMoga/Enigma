using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnigmaMachine.Rotors;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Machine;
using EnigmaMachine.Repository;

namespace EnigmaMachine
{
    class Program
    {
        static void Main(string[] args)
        {           
            var repository = new MemoryRepository();
            Console.WriteLine(repository.AllRotorsNames);
            //var rotorService = new RotatingService();
            

            //var one = repository.GetRotor("I");
            //var two = repository.GetRotor("II");
            //var three = repository.GetRotor("III");
            //one.Position = 0;
            //two.Position = 0;
            //three.Position = 0;

            //var rotors = new RotorsService(one,two,three,rotorService);
            //var reflector = repository.GetReflector("UKW C");

            //var m = new Enigma();
            //var decoder = new EnigmaDecoder();
            //decoder.Reflector = reflector;
            //decoder.RotorsService = rotors;

            //m.Decoder = decoder;


            

            //var b = Console.ReadLine();
            //var a = m.Encode(b);
            ////rlzdlypcwowfbnzcbguczpljbfnbfusumrwlnqzxyejaddkdqlehmvygemhxfdwkffizglvdsfddyaoyxjzrwptunvuhcwmmjagqrwegtvatbichhcfzstnraryuzxhqqxoqwaqabjohgpmmcvkmzjudkyyijanqiqpwzwyspsvkriyqlcxrepgplmqejvmizscsryaumhogltxnkefocyuvnwqfbxohhbecjqyftnfohqumodcysggsdwtwdbwamokrcuh
            //Console.WriteLine(a);
        }
    }
}
