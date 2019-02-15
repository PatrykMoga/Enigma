using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.UI
{
    public class MenuItem
    {
        public int Key { get; set; }
        public string Name { get; set; }

        public Action Action { get; set; }

        public MenuItem(int key, string name, Action action)
        {           
            Key = key;
            Name = name;
            Action = action;
        }
    }
}
