using EnigmaMachine.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnigmaMachine.Repository
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
        

        //public List<string> GetRotorsNames() => Repository.Rotors.Keys.ToList();

        //public List<string> GetReflectorsNames() => Repository.Reflectors.Keys.ToList();
    }
}
