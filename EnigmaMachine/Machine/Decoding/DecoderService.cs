using EnigmaMachine.Machine.Boards;
using EnigmaMachine.UIComponents.Menu;
using System;

namespace EnigmaMachine.Machine.Decoding
{
    public class DecoderService : IMenuComponent
    {
        public Decoder Decoder { get; }
        public MenuItem[] MenuItems { get; }

        public DecoderService(ScramblerBoard scramblerBoard, PlugBoard plugBoard)
        {
            Decoder = new Decoder(scramblerBoard,plugBoard);

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
            var d = Decoder.ScramblerBoardService.ScramblerBoard;
            var plug = Decoder.PlugBoardService.ProvidePlugs(message);
            var strBuilder = new System.Text.StringBuilder();
            foreach (var ch in TranslationService.ConvertCharToEnigmaNumbers(plug))
            {
                d.Rotator.Rotate();

                byte buffer = d.Rotor3.DataRelay.PassValue(ch);
                buffer = d.Rotor2.DataRelay.PassValue(buffer);
                buffer = d.Rotor1.DataRelay.PassValue(buffer);

                buffer = d.Reflector.ReflectValue(buffer);

                buffer = d.Rotor1.DataRelay.ReceiveValue(buffer);
                buffer = d.Rotor2.DataRelay.ReceiveValue(buffer);
                buffer = d.Rotor3.DataRelay.ReceiveValue(buffer);
                
                strBuilder.Append(TranslationService.ConvertEnigmaNumbersToChar(buffer));
            }
            return Decoder.PlugBoardService.ProvidePlugs(strBuilder.ToString());
        }
    }
}
