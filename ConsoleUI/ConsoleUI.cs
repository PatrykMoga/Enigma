using ConsoleUI.UIServiceComponents;

namespace ConsoleUI
{
    public class ConsoleUI
    {
        private readonly IUIService _uiService;

        public ConsoleUI(IUIService uiService)
        {
            _uiService = uiService;
        }
       
        public void Initialize()
        {
            while (true)
            {
                _uiService.Run();
            }
        }
    }
}
