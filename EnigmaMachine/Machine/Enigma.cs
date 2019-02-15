using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Rotors;

namespace EnigmaMachine.Machine
{
    public class Enigma
    {
        public EnigmaDecoder Decoder { get; set; }

        public string Encode(string message) => Decoder.Decode(message);
    }
}
