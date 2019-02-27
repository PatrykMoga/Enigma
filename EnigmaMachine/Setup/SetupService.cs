using EnigmaMachine.Machine.Boards;
using EnigmaMachine.Machine.Rotors;
using EnigmaMachine.Repository;
using EnigmaMachine.UIComponents.Menu;
using System;
using System.Collections.Generic;
using static System.Console;

namespace EnigmaMachine.Setup
{
    public class SetupService : IMenuComponent
    {
        public DataProvider Provider { get; }

        public ScramblerBoard ScramblerBoard { get; }
        public PlugBoard PlugBoard { get; }

        public RotorsSetup Rotors { get;}
        public ReflectorSetup Reflector { get; }
        public PlugsSetup Plugs { get; }

        public MenuItem[] MenuItems { get; }

        public SetupService()
        {
            Provider = new DataProvider(new MemoryRepository());

            ScramblerBoard =
                new ScramblerBoard(Provider.GetRotor("I"), Provider.GetRotor("II"), Provider.GetRotor("III"), Provider.GetReflector("UKW B"));

            PlugBoard = new PlugBoard(new Dictionary<char, char>());

            MenuItems = new[]
            {                                          
                new MenuItem("Exit", Exit)
            };

            Rotors = new RotorsSetup(this);
            Reflector = new ReflectorSetup(this);
            Plugs = new PlugsSetup(this);
        }

        private void Exit()
        {
            WriteLine("Goodbye!");
            Environment.Exit(0);
        }      
    }
}
