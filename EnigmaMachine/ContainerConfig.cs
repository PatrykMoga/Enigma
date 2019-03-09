using Autofac;
using EnigmaMachine.Machine;
using EnigmaMachine.Machine.Boards;
using EnigmaMachine.Machine.Decoding;
using EnigmaMachine.Machine.Reflectors;
using EnigmaMachine.Machine.Rotator;
using EnigmaMachine.Machine.Rotors;
using EnigmaMachine.Repository;
using EnigmaMachine.Setups;
using EnigmaMachine.UIComponents.Menu;
using EnigmaMachine.UIComponents.TopBar;

namespace EnigmaMachine
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();


            return builder.Build();
        }
    }
}
