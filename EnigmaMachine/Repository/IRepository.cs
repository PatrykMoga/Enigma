using EnigmaMachine.Machine.Reflectors;
using EnigmaMachine.Machine.Rotors;
using System.Collections.Generic;

namespace EnigmaMachine.Repository
{
    public interface IRepository
    {
        Dictionary<string, IRotor> Rotors { get; }
        Dictionary<string, IReflector> Reflectors { get; }
    }
}
