using EnigmaMachine.UIComponents.TopBar;

namespace EnigmaMachine.Machine.Boards
{
    public interface IScramblerBoardService : ITopBarComponent
    {
        ScramblerBoard ScramblerBoard { get; }

        void ScramblerBoardBar();
    }
}