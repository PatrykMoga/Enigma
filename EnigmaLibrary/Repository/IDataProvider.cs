using System.Collections.Generic;

namespace EnigmaLibrary
{
    public interface IDataProvider
    {
        IReflector GetReflector(string name);
        Rotor GetRotor(string name);
        IList<string> GetReflectorsNames();
        IList<string> GetRotorsNames();
    }
}