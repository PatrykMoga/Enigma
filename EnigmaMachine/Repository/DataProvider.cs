using EnigmaMachine.Machine.Reflectors;
using EnigmaMachine.Machine.Rotors;
using System.Collections.Generic;
using System.Linq;

namespace EnigmaMachine.Repository
{
    public class DataProvider
    {
        public IRepository Repository { get; }

        public DataProvider(IRepository repository)
        {
            Repository = repository;
        }

        public IRotor GetRotor(string name)
        {
            Repository.Rotors.TryGetValue(name, out IRotor rotor);

            var list = new List<DictionaryRotor>();
            list.Find(r => r.Name == name);
            return rotor;
        }

        public IReflector GetReflector(string name)
        {
            Repository.Reflectors.TryGetValue(name, out IReflector reflector);
            return reflector;
        }

        
        public List<string> GetRotorsNames() => Repository.Rotors.Keys.ToList();

        public List<string> GetReflectorsNames() => Repository.Reflectors.Keys.ToList();
    }
}
