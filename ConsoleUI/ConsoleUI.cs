using ConsoleUI.UIComponents;
using ConsoleUI.UIServiceComponents;
using EnigmaLibrary;

namespace ConsoleUI
{
    public class ConsoleUI
    {
        public DecodingProcessor Procesor { get; }
        public IUIService UIService { get; }

        public ConsoleUI(DecodingProcessor processor, IUIService uiService)
        {
            Procesor = processor;
            UIService = uiService;
        }
       
        public void Initialize()
        {
            while (true)
            {
                UIService.PrintComponents();
            }           
        }
    }
}
