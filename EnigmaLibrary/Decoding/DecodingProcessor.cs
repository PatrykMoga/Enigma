namespace EnigmaLibrary
{
    public class DecodingProcessor
    {
        public ScrambleBoard ScramblerBoard { get; }
        public IPluginBoard PlugBoardService { get; }
        public IRotatingService RotatingService { get; }
        public IDataProvider MemoryDataProvider { get; }

        public DecodingProcessor(ScrambleBoard scramblerBoard, IPluginBoard plugBoardService,
            IRotatingService rotatingService, IDataProvider memoryDataProvider)
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

            foreach (var ch in message)
            {
                RotatingService.Rotate();

                char buffer = ScramblerBoard.Processor3.PassValue(ch);
                buffer = ScramblerBoard.Processor2.PassValue(buffer);
                buffer = ScramblerBoard.Processor1.PassValue(buffer);

                buffer = ScramblerBoard.Reflector.ReflectValue(buffer);

                buffer = ScramblerBoard.Processor1.ReceiveValue(buffer);
                buffer = ScramblerBoard.Processor2.ReceiveValue(buffer);
                buffer = ScramblerBoard.Processor3.ReceiveValue(buffer);

               
                strBuilder.Append(PlugBoardService.SwapChar(buffer));
            }
            return strBuilder.ToString();
        }
    }
}