
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnigmaLibrary
{
    public class MemoryDataProvider /*: IDataProvider*/
    {
        public MemoryRepository Repository { get; }

        public MemoryDataProvider(MemoryRepository repository)
        {
            Repository = repository;
        }

        public DictionaryRotor GetRotor(string name) => Repository.Rotors.First(r => r.Name == name);

        public DictionaryReflector GetReflector(string name) => Repository.Reflectors.First(r => r.Name == name);


        public List<string> GetRotorsNames() => Repository.Rotors.Select(n => n.Name).ToList();

        public List<string> GetReflectorsNames() => Repository.Reflectors.Select(n => n.Name).ToList();
    }
}
