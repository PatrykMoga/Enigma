using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Reflectors
{
    public interface IReflector
    {
        Dictionary<byte, byte> Values { get; }
        byte ReflectValue(byte n);
    }
}
