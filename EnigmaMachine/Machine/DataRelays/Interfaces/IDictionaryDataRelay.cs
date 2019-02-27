using EnigmaMachine.Machine.Rotors;

namespace EnigmaMachine.Machine.DataRelays
{
    public interface IDictionaryDataRelay : IDataRelay
    {
        IDictionaryRotor Rotor { get; set; }
    }
}
