using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Repository;
using EnigmaMachine.UI;

namespace EnigmaMachine.Setup
{
    public class SetupService : IMenuComponent
    {
        private readonly MemoryRepository _repository;
        public MenuItem[] MenuItems { get; }

        public SetupService()
        {
            _repository = new MemoryRepository();
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
