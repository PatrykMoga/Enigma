using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public interface IRotor
    {
        RotorService RotorService { get; }
        Dictionary<byte, byte> Values { get; }

        byte Position { get; set; }
        byte TurnoverPosition { get; }     
    }
}
