using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Rotors;

namespace EnigmaMachine.Repository
{
    public class DataProvider
    {
        public IRepository Repository { get; }

        public DataProvider(IRepository repository)
        {
            Repository = repository;
        }

        public Rotor GetRotor(string name)
        {
            Repository.Rotors.TryGetValue(name, out Rotor rotor);

            var list = new List<Rotor>();
            list.Find(r => r.Name == name);
            return rotor;
        }

        public DictionaryReflector GetReflector(string name)
        {
            Repository.Reflectors.TryGetValue(name, out DictionaryReflector reflector);
            return reflector;
        }

        
        public List<string> GetRotorsNames() => Repository.Rotors.Keys.ToList();

        public List<string> GetReflectorsNames() => Repository.Reflectors.Keys.ToList();
    }
}
