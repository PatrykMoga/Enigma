using EnigmaLibrary;
using System;

namespace ConsoleUI.UIComponents
{
    public class DecodingProcessorUI : BetterIUIComponent
    {
        public DecodingProcessor DecodingProcessor { get; }
        public UIComponent Component { get; }

        public DecodingProcessorUI(DecodingProcessor decodingProcessor)
        {
            DecodingProcessor = decodingProcessor;
            Component = new UIComponent("Decode message", StartDecoding);
        }

        private void StartDecoding()
        {
            Console.Clear();
            Console.Write("Input message: ");
            var input = Console.ReadLine();
            var output = $"Output message: {DecodingProcessor.Decode(input)}";

            Extensions.PrintInLines(output);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
