using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Rotors;
using EnigmaMachine.MenuComponents;

namespace EnigmaMachine.Machine
{
    public class DecodingService : IMenuComponent
    {

        public ScramblerBoard Board { get; set; }
        public MenuItem[] MenuItems { get; }

        //TranslationService ITranslator
        //Plugboard

        public DecodingService(ScramblerBoard scramblerBoard)
        {
            Board = scramblerBoard;

            MenuItems = new[]
            {
                new MenuItem("Decode message",StartDecoding),
            };
        }

        public void StartDecoding()
        {
            Console.Write("Type message: ");
            var message = Console.ReadLine();
            Console.WriteLine("===================================================================================================");
            Console.WriteLine(Decode(message));
            Console.WriteLine("===================================================================================================");
            Console.ReadKey();
            Console.Clear();
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
