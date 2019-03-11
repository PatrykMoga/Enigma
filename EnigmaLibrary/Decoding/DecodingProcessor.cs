using EnigmaLibrary.Boards;
using EnigmaLibrary.Components;
using EnigmaLibrary.Repository;

namespace EnigmaLibrary.Decoding
{
    public class DecodingProcessor : IDecodingProcessor
    {
        private readonly ScrambleBoard _scramblerBoard;
        private readonly IPluginBoard _plugBoardService;
        private readonly IRotatingService _rotatingService;
        private readonly IDataProvider _dataProvider;

        public DecodingProcessor(ScrambleBoard scramblerBoard, IPluginBoard plugBoardService,
            IRotatingService rotatingService, IDataProvider memoryDataProvider)
        {
            _scramblerBoard = scramblerBoard;
            _plugBoardService = plugBoardService;
            _rotatingService = rotatingService;
            _dataProvider = memoryDataProvider;

            _scramblerBoard.Processor1.Rotor = _dataProvider.GetRotor("I");
            _scramblerBoard.Processor2.Rotor = _dataProvider.GetRotor("II");
            _scramblerBoard.Processor3.Rotor = _dataProvider.GetRotor("III");

            _scramblerBoard.Reflector = _dataProvider.GetReflector("UKW B");
        }

        public string Decode(string message)
        {
            var strBuilder = new System.Text.StringBuilder();
            message = _plugBoardService.SwapMessage(message);

            foreach (var ch in message)
            {
                _rotatingService.Rotate();

                char buffer = _scramblerBoard.Processor3.PassValue(ch);
                buffer = _scramblerBoard.Processor2.PassValue(buffer);
                buffer = _scramblerBoard.Processor1.PassValue(buffer);

                buffer = _scramblerBoard.Reflector.ReflectValue(buffer);

                buffer = _scramblerBoard.Processor1.ReceiveValue(buffer);
                buffer = _scramblerBoard.Processor2.ReceiveValue(buffer);
                buffer = _scramblerBoard.Processor3.ReceiveValue(buffer);

               
                strBuilder.Append(_plugBoardService.SwapChar(buffer));
            }
            return strBuilder.ToString();
        }
    }
}