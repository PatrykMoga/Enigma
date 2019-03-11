using ConsoleUI.UIServiceComponents;
using EnigmaLibrary;
using System;

namespace ConsoleUI.UIComponents
{
    public class DecodingProcessorUI : IUIComponent
    {
        private readonly IDecodingProcessor _decodingProcessor;
        public UIComponent Component { get; }

        public DecodingProcessorUI(IDecodingProcessor decodingProcessor)
        {
            _decodingProcessor = decodingProcessor;
            Component = new UIComponent("Decode message", StartDecoding);
        }

        private void StartDecoding()
        {
            Console.Clear();
            Console.Write("Input message: ");
            var input = Console.ReadLine();
            var output = $"Output message: {_decodingProcessor.Decode(input)}";

            output.PrintInLines();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
