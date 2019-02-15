using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Repository;
using EnigmaMachine.Rotors;
using EnigmaMachine.MenuComponents;

namespace EnigmaMachine.Setup
{
    public class SetupService : IMenuComponent
    {
        private readonly MemoryRepository _repository;
        public BoardComponents EnigmaService { get; }
        public MenuItem[] MenuItems { get; }

        public SetupService()
        {
            _repository = new MemoryRepository();
            EnigmaService =
                new BoardComponents(_repository.GetRotor("I"), _repository.GetRotor("II"), _repository.GetRotor("III"), _repository.GetReflector("UKW B"));

            MenuItems = new[]
            {
                new MenuItem(1,"Set up rotors", SetUpRotors)
            };
        }



        public void SetUpRotors()
        {
            Console.WriteLine("Availble rotors: " + _repository.AllRotorsNames);
            Console.Write("Select rotors: ");
        }
    }
}
