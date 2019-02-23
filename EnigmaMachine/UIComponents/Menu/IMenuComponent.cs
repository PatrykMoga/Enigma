using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.MenuComponents
{
    public interface IMenuComponent
    {
        MenuItem[] MenuItems { get; }
    }
}
