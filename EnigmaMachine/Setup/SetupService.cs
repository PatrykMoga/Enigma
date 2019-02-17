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
        private readonly DataProvider _provider;
        public ScramblerBoard EnigmaService { get; }
        public MenuItem[] MenuItems { get; }

        public SetupService()
        {
            _provider = new DataProvider();
            EnigmaService =
                new ScramblerBoard(_provider.GetRotor("I"), _provider.GetRotor("II"), _provider.GetRotor("III"), _provider.GetReflector("UKW B"));

            MenuItems = new[]
            {
                new MenuItem(1,"Set up rotors", SetUpRotors)
            };
        }



        public void SetUpRotors()
        {
            Console.WriteLine("Availble rotors: " + _provider.AllRotorsNames);
            Console.Write("Select rotors: ");
        }
    }
}
