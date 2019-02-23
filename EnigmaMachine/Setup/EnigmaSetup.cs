using System;
using System.Collections.Generic;
using EnigmaMachine.Repository;
using EnigmaMachine.Rotors;
using EnigmaMachine.MenuComponents;
using EnigmaMachine.Machine.Boards;

namespace EnigmaMachine.Setup
{
    public class EnigmaSetup
    {
        private readonly DataProvider _provider;

        public ScramblerBoard ScramblerBoard { get; }

        public EnigmaSetup()
        {
            _provider = new DataProvider(new MemoryRepository());

            ScramblerBoard =
                new ScramblerBoard(_provider.GetRotor("I"), _provider.GetRotor("II"), _provider.GetRotor("III"), _provider.GetReflector("UKW B"));
        }

    }
}
