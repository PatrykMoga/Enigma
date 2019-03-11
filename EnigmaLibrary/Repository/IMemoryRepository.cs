using EnigmaLibrary.Components;
using System.Collections.Generic;

namespace EnigmaLibrary.Repository
{
    public interface IMemoryRepository
    {
        List<IReflector> Reflectors { get; }
        List<Rotor> Rotors { get; }
    }
}