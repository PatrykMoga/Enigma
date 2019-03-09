using EnigmaMachine.UIComponents.Menu;

namespace EnigmaMachine.Setups
{
    public interface ISetupBase
    {
        MenuItem[] MenuItems { get; set; }
        ISetupService SetupService { get; }
    }
}