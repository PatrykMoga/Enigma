namespace EnigmaLibrary
{
    public interface IReflector
    {
        string Name { get; set; }

        byte ReflectValue(byte n);
    }
}