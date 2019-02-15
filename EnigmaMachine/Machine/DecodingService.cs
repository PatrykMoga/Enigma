using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Rotors;

namespace EnigmaMachine.Machine
{
    public class DecodingService
    {
        public BoardComponents EnigmaService { get; set; }

        public DecodingService(BoardComponents enigmaService)
        {
           EnigmaService = enigmaService;
        }
        public string Decode(string message)
        {
            var strBuilder = new StringBuilder();
            foreach (var ch in TranslationService.ConvertCharToEnigmaNumbers(message))
            {
                EnigmaService.Rotate();

                byte buffer = EnigmaService.Rotor3.RotorService.PassValue(ch);
                buffer = EnigmaService.Rotor2.RotorService.PassValue(buffer);
                buffer = EnigmaService.Rotor1.RotorService.PassValue(buffer);

                buffer = EnigmaService.Reflector.ReflectValue(buffer);

                buffer = EnigmaService.Rotor1.RotorService.ReceiveValue(buffer);
                buffer = EnigmaService.Rotor2.RotorService.ReceiveValue(buffer);
                buffer = EnigmaService.Rotor3.RotorService.ReceiveValue(buffer);

                strBuilder.Append(TranslationService.ConvertEnigmaNumbersToChar(buffer));
            }
            return strBuilder.ToString();
        }
    }
}
