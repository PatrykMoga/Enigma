namespace EnigmaLibrary.Components
{
    public interface IReflector
    {
        string Name { get; }
        char ReflectValue(char c);
    }
}