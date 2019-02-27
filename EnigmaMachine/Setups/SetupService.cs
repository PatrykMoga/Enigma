using EnigmaMachine.Machine.Boards;
using EnigmaMachine.Machine.Rotors;
using EnigmaMachine.Repository;
using EnigmaMachine.UIComponents.Menu;
using System;
using System.Collections.Generic;
using static System.Console;

namespace EnigmaMachine.Setups
{
    public class SetupService
    {
        public DataProvider Provider { get; }
        public ScramblerBoard ScramblerBoard { get; }
        public PlugBoard PlugBoard { get; }

        public RotorsSetups RotorsSetups { get;}
        public ReflectorSetups ReflectorSetups { get; }
        public PlugsSetups PlugsSetups { get; }
        public AdditionalSetups AdditionalSetups { get; set; }

        public SetupService()
        {
            Provider = new DataProvider(new MemoryRepository());

            ScramblerBoard =
                new ScramblerBoard(Provider.GetRotor("I"), Provider.GetRotor("II"), Provider.GetRotor("III"), Provider.GetReflector("UKW B"));

            PlugBoard = new PlugBoard(new Dictionary<char, char>());         

            RotorsSetups = new RotorsSetups(this);
            ReflectorSetups = new ReflectorSetups(this);
            PlugsSetups = new PlugsSetups(this);
            AdditionalSetups = new AdditionalSetups(this);
        }
    }
}
