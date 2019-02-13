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
        private readonly IReflector _reflector;

        public Connector Connector { get; set; }

        public Enigma(IReflector reflector)
        {           
            _reflector = reflector;
        }

        public string Encode(string str)
        {

            byte buffer;
            var strBuilder = new StringBuilder();
            foreach (var item in TranslationService.ConvertCharToEnigmaNumbers(str))
            {
                Connector.Rotate();

                buffer = Connector.PassValue(Connector.Rotor3,item);
                buffer = Connector.PassValue(Connector.Rotor2, buffer);
                buffer = Connector.PassValue(Connector.Rotor1, buffer);

                buffer = _reflector.ReflectValue(buffer);

                buffer = Connector.ReceiveValue(Connector.Rotor1,buffer);
                buffer = Connector.ReceiveValue(Connector.Rotor2, buffer);
                buffer = Connector.ReceiveValue(Connector.Rotor3, buffer);

                strBuilder.Append(TranslationService.ConvertEnigmaNumbersToChar(buffer));
            }
           return strBuilder.ToString();
        }



    }
}
