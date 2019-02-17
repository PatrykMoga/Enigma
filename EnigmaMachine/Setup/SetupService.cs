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
        public ScramblerBoard ScramblerBoard { get; }
        public Rotor[] Rotors { get; set; }

        public MenuItem[] MenuItems { get; }

        public SetupService()
        {
            _provider = new DataProvider(new MemoryRepository());
            ScramblerBoard =
                new ScramblerBoard(_provider.GetRotor("I"), _provider.GetRotor("II"), _provider.GetRotor("III"), _provider.GetReflector("UKW B"));

            MenuItems = new[]
            {
                new MenuItem(1,"Set up rotors", SetUpRotors),
                new MenuItem(2,"Set up positions", SetUpRotors),
                new MenuItem(3,"Set up reflector", SetUpRotors)
            };
        }



        public void SetUpRotors()
        {
            Console.WriteLine("Availble rotors: " + _provider.AllRotorsNames);
            Console.Write("Select rotors: ");
        }

        public void SetUpPositions()
        {
            Console.Write($"Set position of rotor : ");
            var input = Console.ReadLine();
            ScramblerBoard.Rotor1.Position = ConvertToRotorPosition(input);

        }

        public byte ConvertToRotorPosition(string input)
        {
            while (true)
            {
                if (byte.TryParse(input, out byte possition) && possition < 26)
                {
                    return possition;
                }
            }
        }
    }
}
