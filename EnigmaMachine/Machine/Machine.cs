using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Rotors;

namespace EnigmaMachine.Machine
{
    public class Kupa
    {

        private readonly IRotor _rotor1;
        private readonly IRotor _rotor2;
        private readonly IRotor _rotor3;
        private readonly IReflector _reflector;
        private readonly IRotorService _rotorService;

        public Kupa(IRotorService rotorService, IRotor rotor1, IRotor rotor2, IRotor rotor3, IReflector reflector)
        {           
            _rotor1 = rotor1;
            _rotor2 = rotor2;
            _rotor3 = rotor3;
            _reflector = reflector;
            _rotorService = rotorService;
        }

        public void Encode(string str)
        {

            byte buffer;
            var strBuilder = new StringBuilder();
            foreach (var item in TranslationService.ConvertStringToInt(str))
            {
                _rotor3.Rotate();
                
                buffer = _rotor3.PassValue(item);
                buffer = _rotor2.PassValue(buffer);
                buffer = _rotor1.PassValue(buffer);
              
                buffer = _reflector.ReflectValue(buffer);

                buffer = _rotor1.ReceiveValue(buffer);
                buffer = _rotor2.ReceiveValue(buffer);
                buffer = _rotor3.ReceiveValue(buffer);

                strBuilder.Append(TranslationService.ConvertIntToString(buffer));
            }
            Console.WriteLine(strBuilder);
        }

        

    }
}
