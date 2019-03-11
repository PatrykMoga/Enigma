using EnigmaLibrary.Components;
using System.Collections.Generic;

namespace EnigmaLibrary.Repository
{
    public interface IDataProvider
    {
        IReflector GetReflector(string name);
        Rotor GetRotor(string name);
        IList<string> GetReflectorsNames();
        IList<string> GetRotorsNames();
    }
}