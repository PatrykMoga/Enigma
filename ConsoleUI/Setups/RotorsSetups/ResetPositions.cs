using ConsoleUI.UIComponents;
using ConsoleUI.UIServiceComponents;
using EnigmaLibrary;

namespace ConsoleUI.Setups
{
    public class ResetPositions : IUIComponent
    {
        public UIComponent Component { get; }
        private RotatingService _rotatingService;

        public ResetPositions(RotatingService rotatingService)
        {
            _rotatingService = rotatingService;
            Component = new UIComponent("Reset rotors positions", Reset);
        }

        private void Reset() => _rotatingService.ResetPositions();
    }
}
