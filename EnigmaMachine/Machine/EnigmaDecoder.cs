using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Rotors;

namespace EnigmaMachine.Machine
{
    public class EnigmaDecoder
    {

        public EnigmaService EnigmaService { get; set; }

        public string Decode(string message)
        {
            var strBuilder = new StringBuilder();
            foreach (var ch in TranslationService.ConvertCharToEnigmaNumbers(message))
            {
                EnigmaService.Rotate();

                byte buffer = EnigmaService.PassValue(EnigmaService.Rotor3, ch);
                buffer = EnigmaService.PassValue(EnigmaService.Rotor2, buffer);
                buffer = EnigmaService.PassValue(EnigmaService.Rotor1, buffer);

                buffer = EnigmaService.Reflector.ReflectValue(buffer);

                buffer = EnigmaService.ReceiveValue(EnigmaService.Rotor1, buffer);
                buffer = EnigmaService.ReceiveValue(EnigmaService.Rotor2, buffer);
                buffer = EnigmaService.ReceiveValue(EnigmaService.Rotor3, buffer);

                strBuilder.Append(TranslationService.ConvertEnigmaNumbersToChar(buffer));
            }
            return strBuilder.ToString();
        }
    }
}
