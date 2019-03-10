using System.Collections.Generic;

namespace EnigmaLibrary
{
    public interface IDataProvider
    {
        DictionaryReflector GetReflector(string name);
        List<string> GetReflectorsNames();
        DictionaryRotor GetRotor(string name);
        List<string> GetRotorsNames();
    }
}