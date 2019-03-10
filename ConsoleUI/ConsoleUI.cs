using ConsoleUI.UIComponents;
using EnigmaLibrary;

namespace ConsoleUI
{
    public class ConsoleUI
    {
        public DecodingProcessor Procesor { get; }
        public UIService UIService { get; }

        public ConsoleUI(DecodingProcessor processor, UIService uiService)
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
