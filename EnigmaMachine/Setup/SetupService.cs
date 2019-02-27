using System;
using System.Collections.Generic;
using EnigmaMachine.Repository;
using EnigmaMachine.Rotors;
using EnigmaMachine.UIComponents.Menu;
using EnigmaMachine.Machine.Boards;
using static System.Console;

namespace EnigmaMachine.Setup
{
    public class SetupService : IMenuComponent
    {
        private readonly DataProvider _provider;

        public ScramblerBoard ScramblerBoard { get; }
        public PlugBoard PlugBoard { get; }
        public MenuItem[] MenuItems { get; }

        public SetupService()
        {
            _provider = new DataProvider(new MemoryRepository());

            ScramblerBoard =
                new ScramblerBoard(_provider.GetRotor("I"), _provider.GetRotor("II"), _provider.GetRotor("III"), _provider.GetReflector("UKW B"));

            PlugBoard = new PlugBoard(new Dictionary<char, char>());

            MenuItems = new[]
            {
                new MenuItem("Setup rotors",SetUpRotors),
                new MenuItem("Setup positions",SetUpPositions),
                new MenuItem("Reset positions",ResetPositions),
                new MenuItem("Setup reflector",SetUpReflector),
                new MenuItem("Add plugs connection",SetupPlugs),
                new MenuItem("Reset plugs connection",ResetPlugs)
            };
        }

        private void ResetPlugs()
        {
            PlugBoard.Plugs.Clear();
        }

        private void ResetPositions()
        {
            ScramblerBoard.Rotator.ResetPositions();
        }

        public void SetUpRotors()
        {
            var names = _provider.GetRotorsNames();
            ScramblerBoard.Rotor1 = SetRotor(names, 1);
            ScramblerBoard.Rotor2 = SetRotor(names, 2);
            ScramblerBoard.Rotor3 = SetRotor(names, 3);
            ScramblerBoard.Rotator.ResetPositions();
            Clear();
        }

        public void SetUpPositions()
        {
            Write($"Set position of Rotor1: ");
            ScramblerBoard.Rotor1.Position = SetRotorPosition();
            Write($"Set position of Rotor2: ");
            ScramblerBoard.Rotor2.Position = SetRotorPosition();
            Write($"Set position of Rotor3: ");
            ScramblerBoard.Rotor3.Position = SetRotorPosition();
            Clear();
        }

        private byte SetRotorPosition()
        {
            while (true)
            {
                var input = ReadLine();
                if (byte.TryParse(input, out byte possition) && possition < 26)
                {
                    return possition;
                }
                else
                {
                    WriteLine("Wrong try again!");
                }
            }
        }

        private DictionaryRotor SetRotor(List<string> names, int number)
        {           
            var rotors = $"Availble rotors: {string.Join(", ", names)}";
            Extensions.PrintLines(rotors.Length);
            WriteLine(rotors);
            Extensions.PrintLines(rotors.Length);
            WriteLine();
            Write($"Set Rotor{number}: ");
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
                    WriteLine("Rotor doesn't exist");
                }
            }
        }

        private void SetUpReflector()
        {
            var reflectors = _provider.GetReflectorsNames();
            var reflector = $"Availble reflectors: {string.Join(", ", reflectors)}";
            Extensions.PrintLines(reflector.Length);
            WriteLine(reflector);
            Extensions.PrintLines(reflector.Length);
            WriteLine();
            Write($"Set reflector: ");
            while (true)
            {
                var input = ReadLine();
                if (reflectors.Contains(input))
                {
                    ScramblerBoard.Reflector = _provider.GetReflector(input);
                    break;
                }
                else
                {
                    WriteLine("Reflector doesn't exist");
                }
            }
        }

        private void SetupPlugs()
        {
            var p = PlugBoard.Plugs;
            var input = ReadLine();
            input = input.ToUpper();
            AddPlugConnection(input[0], input[1]);
            
        }

        public void AddPlugConnection(char c, char h)
        {
            var p = PlugBoard.Plugs;
            if (!p.ContainsKey(c) && !p.ContainsKey(h) && !p.ContainsValue(c) && !p.ContainsValue(h))
            {
                p.Add(c, h);
            }
            else
            {
                Console.WriteLine("Wronga");
            }
        }
    }
}
