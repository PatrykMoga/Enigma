using EnigmaMachine.Repository;
using EnigmaMachine.UIComponents.Menu;

namespace EnigmaMachine.Setup
{
    public class ScramblerBoardSetup : IMenuComponent
    {
        private readonly DataProvider _provider;

        public MenuItem[] MenuItems { get; }

        public ScramblerBoardSetup()
        {
            _provider = new DataProvider(new MemoryRepository());
        }
    }
}
