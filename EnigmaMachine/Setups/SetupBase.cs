using EnigmaMachine.UIComponents.Menu;

namespace EnigmaMachine.Setups
{
    public abstract class SetupBase : IMenuComponent
    {
        public SetupService SetupService { get; }
        public MenuItem[] MenuItems { get; set; }

        public SetupBase(SetupService setupService)
        {
            SetupService = setupService;
        }
    }
}
