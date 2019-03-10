using ConsoleUI.UIComponents;
using EnigmaLibrary;
using static System.Console;

namespace ConsoleUI.Setups
{
    public class ReflectorSetup : IUIComponent
    {
        public UIComponent[] UIComponents { get; }
        public ScramblerBoard Board { get; set; }
        public MemoryDataProvider DataProvider { get; }


        public ReflectorSetup(ScramblerBoard board, MemoryDataProvider dataProvider) 
        {
            Board = board;
            DataProvider = dataProvider;
            UIComponents = new[]
            {
                new UIComponent("Setup reflector",SetupReflector),
            };
        }
      
        private void SetupReflector()
        {
            var reflectors = DataProvider.GetReflectorsNames();
            var reflector = $"Availble reflectors: {string.Join(", ", reflectors)}";

            Extensions.PrintInLines(reflector);
            WriteLine();
            Write($"Set reflector: ");

            while (true)
            {
                var input = ReadLine();
                if (reflectors.Contains(input))
                {
                    Board.Reflector = DataProvider.GetReflector(input);
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
