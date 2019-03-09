using EnigmaMachine.Machine.Boards;
using EnigmaMachine.Repository;

namespace EnigmaMachine.Setups
{
    public interface ISetupService
    {
        AdditionalSetups AdditionalSetups { get; set; }
        PlugBoard PlugBoard { get; }
        PlugsSetups PlugsSetups { get; }
        DataProvider Provider { get; }
        ReflectorSetups ReflectorSetups { get; }
        RotorsSetups RotorsSetups { get; }
        ScramblerBoard ScramblerBoard { get; }
    }
}