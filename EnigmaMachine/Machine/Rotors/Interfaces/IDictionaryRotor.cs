﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public interface IDictionaryRotor : IRotor
    {
        Dictionary<byte, byte> Values { get; }
    }
}
