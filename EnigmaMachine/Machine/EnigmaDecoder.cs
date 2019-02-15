using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Rotors;

namespace EnigmaMachine.Machine
{
    public class EnigmaDecoder
    {
        public IReflector Reflector { get; set; }
        public IRotorsService RotorsService { get; set; }

        public string Decode(string message)
        {          
            var strBuilder = new StringBuilder();
            foreach (var ch in TranslationService.ConvertCharToEnigmaNumbers(message))
            {
                RotorsService.Rotate();

                byte buffer = RotorsService.PassValue(RotorsService.Rotor3, ch);
                buffer = RotorsService.PassValue(RotorsService.Rotor2, buffer);
                buffer = RotorsService.PassValue(RotorsService.Rotor1, buffer);

                buffer = Reflector.ReflectValue(buffer);

                buffer = RotorsService.ReceiveValue(RotorsService.Rotor1, buffer);
                buffer = RotorsService.ReceiveValue(RotorsService.Rotor2, buffer);
                buffer = RotorsService.ReceiveValue(RotorsService.Rotor3, buffer);

                strBuilder.Append(TranslationService.ConvertEnigmaNumbersToChar(buffer));
            }
            return strBuilder.ToString();
        }
    }
}
