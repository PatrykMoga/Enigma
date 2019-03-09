using EnigmaMachine.UIComponents.TopBar;

namespace EnigmaMachine.Machine.Boards
{
    public interface IPlugBoardService : ITopBarComponent
    {
        PlugBoard PlugBoard { get; set; }

        void ShowPlugBoard();
        char SwapChar(char ch);
        string SwapMessage(string message);
    }
}