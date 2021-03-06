﻿using System;

namespace ConsoleUI.UIServiceComponents
{
    public class UIComponent
    {
        public int? Key { get; set; }
        public string Name { get; set; }
        public Action Action { get; set; }
        public bool Executable { get; set; }

        public UIComponent(Action action)
        {
            Action = action;
        }

        public UIComponent(string name, Action action )
        {
            Name = name;
            Action = action;
            Executable = true;
        }
    }
}