namespace EnigmaMachine.Machine
{
    public class ScramblerBoard
    {
        public RotorProcessor Processor1 { get; set; }
        public RotorProcessor Processor2 { get; set; }
        public RotorProcessor Processor3 { get; set; }
        public DictionaryReflector Reflector { get; set; }
            
        public ScramblerBoard(RotorProcessor rotor1, RotorProcessor rotor2, RotorProcessor rotor3,
            DictionaryReflector reflector)
        {
            Processor1 = rotor1;
            Processor2 = rotor2;
            Processor3 = rotor3;
            Reflector = reflector;     
        }
    }
}