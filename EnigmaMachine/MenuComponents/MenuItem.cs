﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.MenuComponents
{
    public class MenuItem
    {       
        public string Name { get; set; }
        public Action Action { get; set; }

        public MenuItem(string name, Action action)
        {           
            Name = name;
            Action = action;
        }        
    }
}
