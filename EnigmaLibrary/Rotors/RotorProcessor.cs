using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaLibrary
{
    public class RotorProcessor : IRotorProcessor
    {
        public Rotor Rotor { get; set; }

        public char PassValue(char i)
        {
            var buff = i - 65 + Rotor.Position;
            if (buff > 25) buff -= 26;
            if (buff < 0) buff += 26;
            buff = Rotor.Values[buff] - Rotor.Position;
            return (char)buff;
        }

        public char ReceiveValue(char i)
        {
            var buff = i + Rotor.Position;
            if (buff > 90) buff -= 26;
            buff = Rotor.Values.IndexOf((char)buff);
            buff = (buff + 65 - Rotor.Position);
            if (buff < 65) buff += 26;
            return (char)buff;
        }
    }
}
