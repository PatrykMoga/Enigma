namespace EnigmaLibrary
{
    public interface IRotorProcessor
    {
        Rotor Rotor { get; set; }

        char PassValue(char i);
        char ReceiveValue(char i);
    }
}