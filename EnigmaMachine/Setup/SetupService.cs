using System;
using System.Collections.Generic;
using EnigmaMachine.Repository;
using EnigmaMachine.Rotors;
using EnigmaMachine.MenuComponents;
using EnigmaMachine.Machine.Boards;
using static System.Console;

namespace EnigmaMachine.Setup
{
    public class SetupService : IMenuComponent
    {
        private readonly DataProvider _provider;

        public ScramblerBoard ScramblerBoard { get; }
        public MenuItem[] MenuItems { get; }

        public SetupService()
        {
            _provider = new DataProvider(new MemoryRepository());

            ScramblerBoard =
                new ScramblerBoard(_provider.GetRotor("I"), _provider.GetRotor("II"), _provider.GetRotor("III"), _provider.GetReflector("UKW B"));

            MenuItems = new[]
            {
                new MenuItem("Setup rotors",SetUpRotors),
                new MenuItem("Setup positions",SetUpPositions),              
                new MenuItem("Setup reflector",SetUpReflector)               
            };
        }

        public void SetUpRotors()
        {
            var names = _provider.RotorsNames;
            ScramblerBoard.Rotor1 = SetRotor(names,1);          
            ScramblerBoard.Rotor2 = SetRotor(names,2);
            ScramblerBoard.Rotor3 = SetRotor(names,3);
            ScramblerBoard.Rotator.ResetPositions();
            Clear();
        }

        public void SetUpPositions()
        {
            Console.Write($"Set position of Rotor1: ");
            ScramblerBoard.Rotor1.Position = SetRotorPosition();
            Console.Write($"Set position of Rotor2: ");
            ScramblerBoard.Rotor2.Position = SetRotorPosition();
            Console.Write($"Set position of Rotor3: ");
            ScramblerBoard.Rotor3.Position = SetRotorPosition();
            Clear();
        }

        private byte SetRotorPosition()
        {
            while (true)
            {
                var input = Console.ReadLine();
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

        private Rotor SetRotor(List<string> names, int number)
        {                  
            Console.WriteLine("===================================================");
            Console.WriteLine($"Availble rotors: {string.Join(", ",names)}");
            Console.WriteLine("===================================================");
            Console.WriteLine();
            Console.Write($"Set Rotor{number}: ");
            while (true)
            {               
                var input = ReadLine();
                if (names.Contains(input))
                {
                    names.Remove(input);
                    return _provider.GetRotor(input);
                }
                else
                {
                    Console.WriteLine("Rotor doesn't exist");
                }              
            }  
        }

        private void SetUpReflector()
        {
            Clear();
        }
    }
}
