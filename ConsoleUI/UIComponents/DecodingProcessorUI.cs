using ConsoleUI.Menu;
using EnigmaLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.UIComponents
{
    public class DecodingProcessorUI : IMenuComponent
    {
        public DecodingProcessor DecodingProcessor { get; }
        public MenuItem[] MenuItems { get; }

        public DecodingProcessorUI(DecodingProcessor decodingProcessor)
        {
            DecodingProcessor = decodingProcessor;
            MenuItems = new[]
            {
                new MenuItem("Decode message",StartDecoding)
            };
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
