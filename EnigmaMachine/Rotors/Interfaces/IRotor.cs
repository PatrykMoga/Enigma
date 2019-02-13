using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public interface IRotor
    {
        Dictionary<byte, byte> Values { get; }
        byte Position { get; set; }
        byte KnockPoint { get; }
    }
}
