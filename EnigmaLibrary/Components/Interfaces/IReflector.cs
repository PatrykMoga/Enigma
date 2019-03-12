namespace EnigmaLibrary.Components
{
    public interface IReflector
    {
        string Name { get; set; }
        char ReflectValue(char c);
    }
}