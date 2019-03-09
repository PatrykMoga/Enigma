using EnigmaMachine.Machine.Decoding;
using EnigmaMachine.Setups;
using EnigmaMachine.UIComponents.Menu;
using EnigmaMachine.UIComponents.TopBar;

namespace EnigmaMachine.Machine
{
    public interface IEnigma
    {
        IDecoderService DecoderService { get; }
        MenuService Menu { get; }
        ISetupService SetupService { get; }
        TopBarService TopBar { get; }

        void Initialize();
    }
}