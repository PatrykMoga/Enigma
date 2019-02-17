using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Reflectors
{
    public interface IReflector
    {
        byte ReflectValue(byte n);
    }
}
