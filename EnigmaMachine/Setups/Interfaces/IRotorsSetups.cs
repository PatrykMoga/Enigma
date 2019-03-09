using System.Collections.Generic;
using EnigmaMachine.Machine.Rotors;

namespace EnigmaMachine.Setups
{
    public interface IRotorsSetups
    {
        void ResetRotorsPositions();
        IRotor SetRotor(List<string> names, int number);
        byte SetRotorPosition();
        void SetupRotors();
        void SetupRotorsPositions();
    }
}