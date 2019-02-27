using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public interface IRotor
    {
        string Name { get; }
        IDataRelay DataRelay { get; }
        byte Position { get; set; }
        byte TurnoverPosition { get; }     
    }
}
