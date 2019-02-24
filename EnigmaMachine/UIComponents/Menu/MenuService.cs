using System.Collections.Generic;
using static System.Console;

namespace EnigmaMachine.UIComponents.Menu
{
    public class MenuService
    {
        private int _index = 1;
        public Dictionary<int, MenuItem> MenuItems { get; set; }

        public MenuService()
        {
            MenuItems = new Dictionary<int, MenuItem>();
        }

        public void PrintMenu()
        {

            foreach (var item in MenuItems)
            {
                WriteLine($"{item.Key}: {item.Value.Name}");
            }
            WriteLine();

            while (true)
            {
                var input = ReadLine();
                ExecuteComponent(input);
                break;
            }
            Clear();
        }

        public void AddComponent(IMenuComponent component)
        {
            foreach (var menuItem in component.MenuItems)
            {
                MenuItems.Add(_index++, menuItem);
            }
        }

        public void ExecuteComponent(string actionKey)
        {
            if (int.TryParse(actionKey, out int key))
            {
                if (MenuItems.ContainsKey(key))
                {
                    MenuItems[key].Action();
                }
                else
                {
                    WriteLine("Wrong command press enter and try again!");
                    ReadKey();
                    Clear();
                }
            }
        }
    }
}
