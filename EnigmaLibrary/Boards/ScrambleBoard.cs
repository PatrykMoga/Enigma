namespace EnigmaLibrary
{
    public class ScrambleBoard
    {
        public DictionaryRotorProcessor Processor1 { get; set; }
        public DictionaryRotorProcessor Processor2 { get; set; }
        public DictionaryRotorProcessor Processor3 { get; set; }
        public IReflector Reflector { get; set; }

        public ScrambleBoard(DictionaryRotorProcessor rotor1, DictionaryRotorProcessor rotor2, DictionaryRotorProcessor rotor3,
            IReflector reflector)
        {
            Processor1 = rotor1;
            Processor2 = rotor2;
            Processor3 = rotor3;
            Reflector = reflector;
        }
    }
}