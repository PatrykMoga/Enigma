namespace EnigmaMachine.Machine.DataRelays
{
    public interface IDataRelay
    {
        byte PassValue(byte index);
        byte ReceiveValue(byte value);
    }
}
