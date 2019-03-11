using System.Collections.Generic;

namespace EnigmaLibrary
{
    public interface IMemoryRepository
    {
        List<IReflector> Reflectors { get; }
        List<Rotor> Rotors { get; }
    }
}