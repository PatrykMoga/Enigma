using EnigmaMachine.Machine.Boards;
using EnigmaMachine.Machine.Rotors;
using EnigmaMachine.Repository;
using EnigmaMachine.UIComponents.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace EnigmaMachine.Setup
{
    public abstract class SetupBase : IMenuComponent
    {
        public SetupService SetupService { get; }
        public MenuItem[] MenuItems { get; set; }

        public SetupBase(SetupService setupService)
        {
            SetupService = setupService;
        }
    }
}
