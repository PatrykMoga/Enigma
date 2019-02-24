﻿using EnigmaMachine.Reflectors;
using EnigmaMachine.Rotors;
using System.Collections.Generic;

namespace EnigmaMachine.Repository
{
    public interface IRepository
    {
        Dictionary<string, Rotor> Rotors { get; }
        Dictionary<string, DictionaryReflector> Reflectors { get; }
    }
}