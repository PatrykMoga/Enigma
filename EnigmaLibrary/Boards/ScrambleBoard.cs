namespace EnigmaLibrary
{
    public class ScrambleBoard
    {
        public IRotorProcessor Processor1 { get; set; }
        public IRotorProcessor Processor2 { get; set; }
        public IRotorProcessor Processor3 { get; set; }
        public IReflector Reflector { get; set; }

        public ScrambleBoard(IRotorProcessor rotor1, IRotorProcessor rotor2,
            IRotorProcessor rotor3, IReflector reflector)
        {
            Processor1 = rotor1;
            Processor2 = rotor2;
            Processor3 = rotor3;
            Reflector = reflector;
        }
    }
}