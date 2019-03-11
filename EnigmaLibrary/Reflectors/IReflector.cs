namespace EnigmaLibrary
{
    public interface IReflector
    {
        string Name { get; set; }

        char ReflectValue(char c);
    }
}