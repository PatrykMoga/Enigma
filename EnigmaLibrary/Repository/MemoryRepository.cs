using EnigmaLibrary.Components;
using System.Collections.Generic;

namespace EnigmaLibrary.Repository
{
    public class MemoryRepository : IMemoryRepository
    {
        public List<Rotor> Rotors { get; }
        public List<IReflector> Reflectors { get; }

        public MemoryRepository()
        {
            Rotors = new List<Rotor>()
            {
                new Rotor { Name = "I", TurnoverPosition = 16, Values = "EKMFLGDQVZNTOWYHXUSPAIBRCJ" },
                new Rotor { Name = "II", TurnoverPosition = 4, Values = "AJDKSIRUXBLHWTMCQGZNPYFVOE" },
                new Rotor { Name = "III", TurnoverPosition = 21, Values = "BDFHJLCPRTXVZNYEIWGAKMUSQO" },
                new Rotor { Name = "IV", TurnoverPosition = 21, Values = "ESOVPZJAYQUIRHXLNFTGKDCMWB" },
                new Rotor { Name = "V", TurnoverPosition = 21, Values = "VZBRGITYUPSDNHLXAWMJQOFECK" }
            };

            Reflectors = new List<IReflector>()
            {
                new Reflector{ Name = "UKW B", Values = new Dictionary<char, char>
                {
                    {'A','Y'},
                    {'B','R'},
                    {'C','U'},
                    {'D','H'},
                    {'E','Q'},
                    {'F','S'},
                    {'G','L'},
                    {'I','P'},
                    {'J','X'},
                    {'K','N'},
                    {'M','O'},
                    {'T','Z'},
                    {'V','W'}
                }},
                new Reflector{ Name = "UKW C", Values = new Dictionary<char, char>
                {
                    {'A','F'},
                    {'B','V'},
                    {'C','P'},
                    {'D','J'},
                    {'E','I'},
                    {'G','O'},
                    {'H','Y'},
                    {'K','R'},
                    {'L','Z'},
                    {'M','X'},
                    {'N','W'},
                    {'Q','T'},
                    {'S','U'}
                }}               
            };
        }
    }
}
