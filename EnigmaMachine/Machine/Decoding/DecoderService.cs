using EnigmaMachine.Machine.Boards;
using EnigmaMachine.MenuComponents;
using System;

namespace EnigmaMachine.Machine.Decoding
{
    public class DecoderService : IMenuComponent
    {
        public Decoder Decoder { get; }
        public MenuItem[] MenuItems { get; }

        public DecoderService(ScramblerBoard scramblerBoard)
        {
            Decoder = new Decoder(scramblerBoard);

            MenuItems = new[]
            {
                new MenuItem("Decode message",StartDecoding),
            };
        }

        public void StartDecoding()
        {
            Console.Write("Type message: ");
            var message = Console.ReadLine();
            Extensions.PrintLines(message.Length);
            Console.WriteLine(Decode(message));
            Extensions.PrintLines(message.Length);
            Console.ReadKey();
            Console.Clear();
        }

        public string Decode(string message)
        {
            var strBuilder = new System.Text.StringBuilder();
            foreach (var ch in TranslationService.ConvertCharToEnigmaNumbers(message))
            {
                Decoder.ScramblerBoardService.ScramblerBoard.Rotator.Rotate();

                byte buffer = Decoder.ScramblerBoardService.ScramblerBoard.Rotor3.DataRelay.PassValue(ch);
                buffer = Decoder.ScramblerBoardService.ScramblerBoard.Rotor2.DataRelay.PassValue(buffer);
                buffer = Decoder.ScramblerBoardService.ScramblerBoard.Rotor1.DataRelay.PassValue(buffer);

                buffer = Decoder.ScramblerBoardService.ScramblerBoard.Reflector.ReflectValue(buffer);

                buffer = Decoder.ScramblerBoardService.ScramblerBoard.Rotor1.DataRelay.ReceiveValue(buffer);
                buffer = Decoder.ScramblerBoardService.ScramblerBoard.Rotor2.DataRelay.ReceiveValue(buffer);
                buffer = Decoder.ScramblerBoardService.ScramblerBoard.Rotor3.DataRelay.ReceiveValue(buffer);

                strBuilder.Append(TranslationService.ConvertEnigmaNumbersToChar(buffer));
            }
            return strBuilder.ToString();
        }        
    }
}
