using EnigmaMachine.UIComponents.Menu;
using static System.Console;

namespace EnigmaMachine.Setups
{
    public class ReflectorSetups : SetupBase
    {
        public ReflectorSetups(SetupService setupService) : base(setupService)
        {
            MenuItems = new[]
            {
                new MenuItem("Setup reflector",SetupReflector),
            };
        }

        private void SetupReflector()
        {
            var reflectors = SetupService.Provider.GetReflectorsNames();
            var reflector = $"Availble reflectors: {string.Join(", ", reflectors)}";

            Extensions.PrintInLines(reflector);
            WriteLine();
            Write($"Set reflector: ");

            while (true)
            {
                var input = ReadLine();
                if (reflectors.Contains(input))
                {
                    SetupService.ScramblerBoard.Reflector = SetupService.Provider.GetReflector(input);
                    break;
                }
                else
                {
                    WriteLine("Reflector doesn't exist");
                }
            }
        }
    }
}
