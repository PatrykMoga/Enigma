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
            Console.Clear();
            Console.Write("Input message: ");
            var input = Console.ReadLine();
            var output = $"Output message: {Decode(input)}";
            
            Extensions.PrintInLines(output);
            Console.ReadKey();
            Console.Clear();
        }

        public string Decode(string message)
        {
            var d = Decoder.ScramblerBoardService.ScramblerBoard;     
            
            var strBuilder = new System.Text.StringBuilder();
            message = Decoder.PlugBoardService.SwapMessage(message);

            foreach (var ch in TranslationService.ConvertToNumber(message))
            {
                d.Rotator.Rotate();

                byte buffer = d.Rotor3.DataRelay.PassValue(ch);
                buffer = d.Rotor2.DataRelay.PassValue(buffer);
                buffer = d.Rotor1.DataRelay.PassValue(buffer);

                buffer = d.Reflector.ReflectValue(buffer);

                buffer = d.Rotor1.DataRelay.ReceiveValue(buffer);
                buffer = d.Rotor2.DataRelay.ReceiveValue(buffer);
                buffer = d.Rotor3.DataRelay.ReceiveValue(buffer);

                var c = TranslationService.ConvertToChar(buffer);

                strBuilder.Append(Decoder.PlugBoardService.SwapChar(c));
            }
            return strBuilder.ToString();
        }
    }
}
