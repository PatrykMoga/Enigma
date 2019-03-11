﻿using ConsoleUI.UIComponents;
using EnigmaLibrary;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
using ConsoleUI.UIServiceComponents;

namespace ConsoleUI.Setups
{
    public class AddPluginConnection : IUIComponent
    {
        private readonly PluginBoard _pluginBoard;
        public UIComponent Component { get; }

        public AddPluginConnection(PluginBoard pluginBoard)
        {
            _pluginBoard = pluginBoard;
            Component = new UIComponent("Add plugin connection", SetConnection);
        }

        private void SetConnection()
        {
            Clear();
            Write("Enter the connection in this format (XY): ");
            var p = _pluginBoard.Plugins;
            var input = ReadLine();
            input = input.ToUpper();
            AddConnection(input[0], input[1]);
        }

        private void AddConnection(char c, char h)
        {
            var p = _pluginBoard.Plugins;
            if (!p.ContainsKey(c) && !p.ContainsKey(h) && !p.ContainsValue(c) && !p.ContainsValue(h))
            {
                p.Add(c, h);
            }
            else
            {
                WriteLine("Plugin is already connected or input is in wrong format");
            }
        }
    }
}