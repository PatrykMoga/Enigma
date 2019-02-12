using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Rotors;

namespace EnigmaMachine.Machine
{
    public class Connector<T> where T : IRotor
    {                       
        public byte PassValue<T>(IRotorService rotorService, byte value) => IRotorService.PassValue(value);

        public byte ReceiveValue<T>(byte value) => _rotorService.ReceiveValue(value);

        public void Rotate<T>() => t.Position++;
    }
}
