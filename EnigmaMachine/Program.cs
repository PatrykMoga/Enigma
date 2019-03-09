using EnigmaMachine.Machine;

namespace EnigmaMachine
{
    internal static class Program
    {
        private static void Main()
        {            
            var enigma = new Enigma();
            enigma.Initialize();
        }
    }
}
