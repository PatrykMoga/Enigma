﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public interface IDataRelay
    {
        IRotor Rotor { get; set; }

        byte PassValue(byte index);
        byte ReceiveValue(byte value);
    }
}