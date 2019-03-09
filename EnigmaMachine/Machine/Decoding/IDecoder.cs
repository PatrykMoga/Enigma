using EnigmaMachine.Machine.Boards;

namespace EnigmaMachine.Machine.Decoding
{
    public interface IDecoder
    {
        IPlugBoardService PlugBoardService { get; set; }
        IScramblerBoardService ScramblerBoardService { get; set; }
    }
}