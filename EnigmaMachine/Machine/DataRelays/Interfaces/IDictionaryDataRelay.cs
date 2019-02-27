using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public interface IDictionaryDataRelay : IDataRelay
    {
        IDictionaryRotor Rotor { get; set; }
    }
}
