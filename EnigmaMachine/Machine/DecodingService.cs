using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Rotors;

namespace EnigmaMachine.Machine
{
    public class DecodingService
    {

        public ScramblerBoard Board { get; set; }

        public DecodingService(ScramblerBoard scramblerBoard)
        {
           Board = scramblerBoard;
        }
        public string Decode(string message)
        {
            var strBuilder = new StringBuilder();
            foreach (var ch in TranslationService.ConvertCharToEnigmaNumbers(message))
            {
                Board.Rotator.Rotate();

                byte buffer = Board.Rotor3.DataRelay.PassValue(ch);
                buffer = Board.Rotor2.DataRelay.PassValue(buffer);
                buffer = Board.Rotor1.DataRelay.PassValue(buffer);

                buffer = Board.Reflector.ReflectValue(buffer);

                buffer = Board.Rotor1.DataRelay.ReceiveValue(buffer);
                buffer = Board.Rotor2.DataRelay.ReceiveValue(buffer);
                buffer = Board.Rotor3.DataRelay.ReceiveValue(buffer);

                strBuilder.Append(TranslationService.ConvertEnigmaNumbersToChar(buffer));
            }
            return strBuilder.ToString();
        }
    }
}
