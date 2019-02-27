using EnigmaMachine.Machine.Boards;

namespace EnigmaMachine.Machine.Decoding
{
    public class Decoder
    {
        public ScramblerBoardService ScramblerBoardService { get; set; }
        public PlugBoardService PlugBoardService { get; set; }

        public Decoder(ScramblerBoard scramblerBoard, PlugBoard plugBoard)
        {
            ScramblerBoardService = new ScramblerBoardService(scramblerBoard);
            PlugBoardService = new PlugBoardService(plugBoard);
        }
    }
}
