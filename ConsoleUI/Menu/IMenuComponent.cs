using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.Menu
{
    public interface IMenuComponent
    {
        MenuItem[] MenuItems { get; }
    }
}
