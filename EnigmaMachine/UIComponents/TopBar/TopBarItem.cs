using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.UIComponents.TopBar
{
    public class TopBarItem
    {
        public Action Action { get; set; }

        public TopBarItem(Action action)
        {
            Action = action;
        }
    }
}
