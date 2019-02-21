using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Repository;
using EnigmaMachine.Rotors;
using EnigmaMachine.MenuComponents;
using static System.Console;

namespace EnigmaMachine.Setup
{
    public class SetupService : IMenuComponent
    {
        private readonly DataProvider _provider;
        public ScramblerBoard ScramblerBoard { get; }

        public MenuItem[] MenuItems { get; }

        //Plug board


        public SetupService()
        {
            _provider = new DataProvider(new MemoryRepository());

            ScramblerBoard =
                new ScramblerBoard(_provider.GetRotor("I"), _provider.GetRotor("II"), _provider.GetRotor("III"), _provider.GetReflector("UKW B"));

            MenuItems = new[]
            {
                new MenuItem("Setup rotors",SetUpRotors),
                new MenuItem("Setup positions",SetUpPositions)               
            };
        }
       
        public void SetUpRotors()
        {
            Console.WriteLine(_provider.AllRotorsNames);
            var input = Console.ReadLine();
            ScramblerBoard.Rotor1 = _provider.GetRotor(input);
            input = Console.ReadLine();
            ScramblerBoard.Rotor2 = _provider.GetRotor(input);
            input = Console.ReadLine();
            ScramblerBoard.Rotor3 = _provider.GetRotor(input);
            ScramblerBoard.Rotator.ResetPositions();
        }

        public void SetUpPositions()
        {
            Console.Write($"Set position of Rotor1: ");
            var input = Console.ReadLine();
            ScramblerBoard.Rotor1.Position = ConvertToRotorPosition(input);
            Console.Write($"Set position of Rotor2: ");
            input = Console.ReadLine();
            ScramblerBoard.Rotor2.Position = ConvertToRotorPosition(input);
            Console.Write($"Set position of Rotor3: ");
            input = Console.ReadLine();
            ScramblerBoard.Rotor3.Position = ConvertToRotorPosition(input);

        }

        private byte ConvertToRotorPosition(string input)
        {
            while (true)
            {
                if (byte.TryParse(input, out byte possition) && possition < 26)
                {
                    return possition;
                }
                else
                {
                    Console.WriteLine("Wrong try again!");
                }
            }
        }
    }
}
