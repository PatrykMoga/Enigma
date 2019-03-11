using ConsoleUI.UIServiceComponents;
using EnigmaLibrary;

namespace ConsoleUI.Setups
{
    public class ResetRotorsPositions : IUIComponent
    {
        private readonly IRotatingService _rotatingService;
        public UIComponent Component { get; }
        
        public ResetRotorsPositions(IRotatingService rotatingService)
        {
            _rotatingService = rotatingService;
            Component = new UIComponent("Reset rotors positions", ResetPositions);
        }

        private void ResetPositions() => _rotatingService.ResetPositions();
    }
}
