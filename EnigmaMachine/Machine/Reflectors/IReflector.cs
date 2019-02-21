using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Reflectors
{
    public interface IReflector
    {
        string Name { get; }
        byte ReflectValue(byte n);
    }
}
