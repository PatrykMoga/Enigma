using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleUI.Menu
{
    public class MenuService
    {
        private int _index = 1;
        private IEnumerable<IMenuComponent> _menuComponents;
        public Dictionary<int, MenuItem> MenuItems { get; set; }

        public MenuService(IEnumerable<IMenuComponent> menuComponents)
        {
            _menuComponents = menuComponents;
            MenuItems = new Dictionary<int, MenuItem>();
            RegisterWithKey();
        }

        private void RegisterWithKey()
        {
            foreach (var components in _menuComponents)
            {
                foreach (var component in components.MenuItems)
                {
                    MenuItems.Add(_index++, component);
                }
            }
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

        private void ExecuteComponent(string actionKey)
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
