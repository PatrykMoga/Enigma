
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnigmaLibrary
{
    public class MemoryDataProvider : IDataProvider
    {
        private readonly IMemoryRepository _repository;

        public MemoryDataProvider(IMemoryRepository repository)
        {
            _repository = repository;
        }

        public Rotor GetRotor(string name) => _repository.Rotors.First(r => r.Name == name);

        public IReflector GetReflector(string name) => _repository.Reflectors.First(r => r.Name == name);


        public IList<string> GetRotorsNames() => _repository.Rotors.Select(n => n.Name).ToList();

        public IList<string> GetReflectorsNames() => _repository.Reflectors.Select(n => n.Name).ToList();
    }
}
