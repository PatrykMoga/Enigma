using System;
using System.Collections.Generic;
using System.Text;

namespace NewRotorTest
{
    public class Rotor
    {
        public string Name { get; set; }
        public string Values { get; set; }
        public byte Position { get; set; } = 0;
        public byte TurnoverPosition { get; set; }
    }
}

//Rotors2 = new List<Rotor>()
//        {
//            new Rotor{ Name = "I", TurnoverPosition = 17 , Values = "EKMFLGDQVZNTOWYHXUSPAIBRCJ"},
//            new Rotor{ Name = "II", TurnoverPosition = 4 , Values = "AJDKSIRUXBLHWTMCQGZNPYFVOE"},
//            new Rotor{ Name = "III", TurnoverPosition = 21 , Values = "BDFHJLCPRTXVZNYEIWGAKMUSQO"}
//        };
