using System.Collections.Generic;
using EnigmaMachine.Machine;

namespace EnigmaMachine.Repository
{
    public interface IDataProvider
    {
        DictionaryReflector GetReflector(string name);
        List<string> GetReflectorsNames();
        DictionaryRotor GetRotor(string name);
        List<string> GetRotorsNames();
    }
}