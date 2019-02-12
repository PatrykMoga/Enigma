using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public interface IRotorService
    {     
        byte PassValue(byte index);
        byte ReceiveValue(byte value);      
    }
}
