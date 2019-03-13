namespace EnigmaLibrary.Components
{
    public class RotorProcessor : IRotorProcessor
    {
        public Rotor Rotor { get; set; }

        public char PassValue(char ch)
        {
            var rotation = Rotor.Values.Substring(Rotor.Position) + Rotor.Values.Substring(0, Rotor.Position);
            var index = ch - 65;
            var passedWire = rotation[index];

            var output = passedWire - Rotor.Position;
            if (output < 65)
            {
                output += 26;
            }

            return (char)(output);
        }

        public char ReceiveValue(char ch)
        {
            var inputCh = ch + Rotor.Position;
            if (inputCh > 90) inputCh -= 26;

            var index = Rotor.Values.IndexOf((char)inputCh);

            var outputCh = (index + 65 - Rotor.Position);
            if (outputCh < 65) outputCh += 26;

            return (char)outputCh;
        }
    }
}
