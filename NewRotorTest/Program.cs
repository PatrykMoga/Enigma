using System;

namespace NewRotorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var rotor1 = new Rotor { Name = "I", TurnoverPosition = 17, Values = "EKMFLGDQVZNTOWYHXUSPAIBRCJ" };
            var rotor2 = new Rotor { Name = "II", TurnoverPosition = 4, Values = "AJDKSIRUXBLHWTMCQGZNPYFVOE" };
            var rotor3 = new Rotor { Name = "III", TurnoverPosition = 21, Values = "BDFHJLCPRTXVZNYEIWGAKMUSQO" };
            var reflector = new Reflector();

            var procesoor1 = new RotorProcessor { Rotor = rotor1 };
            var procesoor2 = new RotorProcessor { Rotor = rotor2 };
            var procesoor3 = new RotorProcessor { Rotor = rotor3 };

            var message = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";

            foreach (var ch in message)
            {
                procesoor3.Rotor.Position++;
                var c = procesoor3.PassValue(ch);
                c = procesoor2.PassValue(c);
                c = procesoor1.PassValue(c);

                c = reflector.Reflect(c);

                c = procesoor1.ReceiveValue(c);
                c = procesoor2.ReceiveValue(c);
                c = procesoor3.ReceiveValue(c);

                Console.WriteLine(c);
            }

        }

        public void Decode(string message)
        {
            
        }
    }
}
