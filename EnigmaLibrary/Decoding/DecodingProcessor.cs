using EnigmaLibrary.Boards;
using EnigmaLibrary.Components;
using EnigmaLibrary.Repository;

namespace EnigmaLibrary.Decoding
{
    public class DecodingProcessor : IDecodingProcessor
    {
        private readonly ScrambleBoard _scrambleBoard;
        private readonly IPluginBoard _plugBoardService;
        private readonly IRotatingService _rotatingService;
        private readonly IDataProvider _dataProvider;

        public DecodingProcessor(ScrambleBoard scrambleBoard, IPluginBoard plugBoardService,
            IRotatingService rotatingService, IDataProvider memoryDataProvider)
        {
            _scrambleBoard = scrambleBoard;
            _plugBoardService = plugBoardService;
            _rotatingService = rotatingService;
            _dataProvider = memoryDataProvider;

            _scrambleBoard.Processor1.Rotor = _dataProvider.GetRotor("I");
            _scrambleBoard.Processor2.Rotor = _dataProvider.GetRotor("II");
            _scrambleBoard.Processor3.Rotor = _dataProvider.GetRotor("III");

            _scrambleBoard.Reflector = _dataProvider.GetReflector("UKW B");
        }

        public string Decode(string message)
        {
            var strBuilder = new System.Text.StringBuilder();

            //Only characters from 'A' to 'Z' pass
            message = message.AdaptInput();

            foreach (var ch in message)
            {
                //Signal goes through the plugin board and replaces characters if the connection exists
                var buffer = _plugBoardService.SwapChar(ch);
                //Performs rotation of the entire board
                _rotatingService.Rotate();
                //Sends signal through all the rotors
                buffer = _scrambleBoard.Processor3.PassValue(buffer);
                buffer = _scrambleBoard.Processor2.PassValue(buffer);
                buffer = _scrambleBoard.Processor1.PassValue(buffer);
                //Returns reflected character
                buffer = _scrambleBoard.Reflector.ReflectValue(buffer);
                //Sends signal back through all the rotors
                buffer = _scrambleBoard.Processor1.ReceiveValue(buffer);
                buffer = _scrambleBoard.Processor2.ReceiveValue(buffer);
                buffer = _scrambleBoard.Processor3.ReceiveValue(buffer);
                //Signal goes again through the plugin board and replaces characters if the connection exists
                buffer = _plugBoardService.SwapChar(buffer);
                //Appends encoded character
                strBuilder.Append(buffer);
            }
            return strBuilder.ToString();
        }
    }
}