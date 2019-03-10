using ConsoleUI.Menu;
using EnigmaLibrary;
using static System.Console;

namespace ConsoleUI.Setups
{
    public class PlugBoardSetup : IMenuComponent
    {
        public MenuItem[] MenuItems { get; }
        public PlugBoard PlugBoard { get; }

        public PlugBoardSetup(PlugBoard plugBoard)
        {
            PlugBoard = plugBoard;
            MenuItems = new[]
            {
                new MenuItem("Add plug connection",SetupPlugs),
                new MenuItem("Reset plugs connection",ResetPlugs),
            };
        }

        private void ResetPlugs() => PlugBoard.Plugs.Clear();

        private void SetupPlugs()
        {
            Clear();
            Write("Enter the connection in this format (XY): ");
            var p = PlugBoard.Plugs;
            var input = ReadLine();
            input = input.ToUpper();
            AddPlugConnection(input[0], input[1]);
        }

        public void AddPlugConnection(char c, char h)
        {
            var p = PlugBoard.Plugs;
            if (!p.ContainsKey(c) && !p.ContainsKey(h) && !p.ContainsValue(c) && !p.ContainsValue(h))
            {
                p.Add(c, h);
            }
            else
            {
                WriteLine("Plug is already connected or input is in wrong format");
            }
        }
    }
}
