namespace EnigmaLibrary.Components
{
    public interface IRotorProcessor
    {
        Rotor Rotor { get; set; }
        char PassValue(char ch);
        char ReceiveValue(char ch);
    }
}