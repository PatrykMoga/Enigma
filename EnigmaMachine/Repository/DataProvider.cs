using System;
using System.Collections.Generic;
using System.Text;
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

        public Reflector GetReflector(string name)
        {
            Repository.Reflectors.TryGetValue(name, out Reflector reflector);
            return reflector;
        }

        public string AllRotorsNames => string.Join(' ', Repository.Rotors.Keys);

        public string AllRefletorsNames => string.Join(' ', Repository.Reflectors.Keys);
    }
}
