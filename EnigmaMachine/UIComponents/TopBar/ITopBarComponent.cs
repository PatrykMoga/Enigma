using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.UIComponents.TopBar
{
    public interface ITopBarComponent
    {
        TopBarItem[] TopBarComponents { get; }
    }
}
