using ConsoleUI.UIComponents;
using ConsoleUI.UIServiceComponents;
using EnigmaLibrary;
using static System.Console;

namespace ConsoleUI.Setups
{
    public class SetReflector : IUIComponent
    {
        private readonly ScrambleBoard _board;
        private readonly IDataProvider _dataProvider;
        public UIComponent Component { get; }

        public SetReflector(ScrambleBoard board, IDataProvider dataProvider)
        {
            _board = board;
            _dataProvider = dataProvider;
            Component = new UIComponent("Set reflector", Set);
        }

        private void Set()
        {
            Clear();
            var reflectors = _dataProvider.GetReflectorsNames();
            var reflector = $"Availble reflectors: {string.Join(", ", reflectors)}";

            Extensions.PrintInLines(reflector);
            WriteLine();
            Write($"Set reflector: ");

            while (true)
            {
                var input = ReadLine();
                if (reflectors.Contains(input))
                {
                    _board.Reflector = _dataProvider.GetReflector(input);
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
