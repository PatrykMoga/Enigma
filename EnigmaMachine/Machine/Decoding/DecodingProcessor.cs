using EnigmaMachine.Repository;

namespace EnigmaMachine.Machine
{
    public class DecodingProcessor
    {
        public ScramblerBoardService ScramblerBoardService { get; }
        public PlugBoardService PlugBoardService { get; }
        public RotatingService RotatingService { get; }
        public MemoryDataProvider MemoryDataProvider { get; }

        public DecodingProcessor(ScramblerBoardService scramblerBoardService, PlugBoardService plugBoardService,
            RotatingService rotatingService, MemoryDataProvider memoryDataProvider)
        {
            ScramblerBoardService = scramblerBoardService;
            PlugBoardService = plugBoardService;
            RotatingService = rotatingService;
            MemoryDataProvider = memoryDataProvider;

            ScramblerBoardService.ScramblerBoard.Processor1.Rotor = MemoryDataProvider.GetRotor("I");
            ScramblerBoardService.ScramblerBoard.Processor2.Rotor = MemoryDataProvider.GetRotor("II");
            ScramblerBoardService.ScramblerBoard.Processor3.Rotor = MemoryDataProvider.GetRotor("III");

            ScramblerBoardService.ScramblerBoard.Reflector = MemoryDataProvider.GetReflector("UKW B");
        }

        public string Decode(string message)
        {
            var scramblerBoard = ScramblerBoardService.ScramblerBoard;

            var strBuilder = new System.Text.StringBuilder();
            message = PlugBoardService.SwapMessage(message);

            foreach (var ch in TranslationService.ConvertToNumber(message))
            {
                RotatingService.Rotate();

                byte buffer = scramblerBoard.Processor3.PassValue(ch);
                buffer = scramblerBoard.Processor2.PassValue(buffer);
                buffer = scramblerBoard.Processor1.PassValue(buffer);

                buffer = scramblerBoard.Reflector.ReflectValue(buffer);

                buffer = scramblerBoard.Processor1.ReceiveValue(buffer);
                buffer = scramblerBoard.Processor2.ReceiveValue(buffer);
                buffer = scramblerBoard.Processor3.ReceiveValue(buffer);

                var c = TranslationService.ConvertToChar(buffer);

                strBuilder.Append(PlugBoardService.SwapChar(c));
            }
            return strBuilder.ToString();
        }
    }
}