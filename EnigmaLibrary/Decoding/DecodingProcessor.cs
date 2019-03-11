namespace EnigmaLibrary
{
    public class DecodingProcessor
    {
        public ScrambleBoard ScramblerBoard { get; }
        public PluginBoard PlugBoardService { get; }
        public RotatingService RotatingService { get; }
        public MemoryDataProvider MemoryDataProvider { get; }

        public DecodingProcessor(ScrambleBoard scramblerBoard, PluginBoard plugBoardService,
            RotatingService rotatingService, MemoryDataProvider memoryDataProvider)
        {
            ScramblerBoard = scramblerBoard;
            PlugBoardService = plugBoardService;
            RotatingService = rotatingService;
            MemoryDataProvider = memoryDataProvider;

            ScramblerBoard.Processor1.Rotor = MemoryDataProvider.GetRotor("I");
            ScramblerBoard.Processor2.Rotor = MemoryDataProvider.GetRotor("II");
            ScramblerBoard.Processor3.Rotor = MemoryDataProvider.GetRotor("III");
            ScramblerBoard.Reflector = MemoryDataProvider.GetReflector("UKW B");
        }

        public string Decode(string message)
        {
            var strBuilder = new System.Text.StringBuilder();
            message = PlugBoardService.SwapMessage(message);

            foreach (var ch in TranslationService.ConvertToNumber(message))
            {
                RotatingService.Rotate();

                byte buffer = ScramblerBoard.Processor3.PassValue(ch);
                buffer = ScramblerBoard.Processor2.PassValue(buffer);
                buffer = ScramblerBoard.Processor1.PassValue(buffer);

                buffer = ScramblerBoard.Reflector.ReflectValue(buffer);

                buffer = ScramblerBoard.Processor1.ReceiveValue(buffer);
                buffer = ScramblerBoard.Processor2.ReceiveValue(buffer);
                buffer = ScramblerBoard.Processor3.ReceiveValue(buffer);

                var c = TranslationService.ConvertToChar(buffer);

                strBuilder.Append(PlugBoardService.SwapChar(c));
            }
            return strBuilder.ToString();
        }
    }
}