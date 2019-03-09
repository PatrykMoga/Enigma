using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Machine
{
    public class Enigma
    {
        public DecodingProcessor Procesor { get; }

        public Enigma(DecodingProcessor processor)
        {
            Procesor = processor;
        }

        public void Initialize()
        {
            Console.ReadLine();
            var output = Procesor.Decode("barbara");
            Console.WriteLine(output);
        }
    }
}
