using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Machine.Reflectors
{
    public interface IReflector
    {
        string Name { get; }
        byte ReflectValue(byte n);
    }
}
