using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EnigmaMachine.Rotors;

namespace EnigmaMachine.MenuComponents
{
    public class MenuService
    {
        private int _index = 1;
        public Dictionary<int,MenuItem> MenuItems { get; set; }

        public MenuService()
        {
            MenuItems = new Dictionary<int, MenuItem>();
        }
       
        public void PrintMenu()
        {
            
            foreach (var item in MenuItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Name}");
            }
            Console.WriteLine();
            while (true)
            {
                var input = Console.ReadLine();
                ExecuteComponent(input);
                break;
            }
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
                    Console.WriteLine("Wrong command!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }           
        }
    }
}
