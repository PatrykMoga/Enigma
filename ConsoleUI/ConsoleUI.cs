using ConsoleUI.UIServiceComponents;
using EnigmaLibrary;

namespace ConsoleUI
{
    public class ConsoleUI
    {
        private readonly IDecodingProcessor _procesor;
        private readonly IUIService _uiService;

        public ConsoleUI(IDecodingProcessor processor, IUIService uiService)
        {
            _procesor = processor;
            _uiService = uiService;
        }
       
        public void Initialize()
        {
            while (true)
            {
                _uiService.PrintComponents();
            }
        }
    }
}
