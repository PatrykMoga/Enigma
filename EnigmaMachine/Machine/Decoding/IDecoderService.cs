using EnigmaMachine.UIComponents.Menu;

namespace EnigmaMachine.Machine.Decoding
{
    public interface IDecoderService : IMenuComponent
    {
        IDecoder Decoder { get; }

        string Decode(string message);
        void StartDecoding();
    }
}