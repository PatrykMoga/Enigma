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

            var b = Rotor.Values.IndexOf((char)buff);
            var a = (b + 65 - Rotor.Position);
            if (a < 65) a += 26;
            return (char)a;
        }
    }
}
