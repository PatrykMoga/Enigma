using Autofac;
using ConsoleUI.Menu;
using ConsoleUI.Setups;
using ConsoleUI.UIComponents;
using EnigmaLibrary;

namespace ConsoleUI
{
    public static class ConsoleContainer
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();            
            builder.RegisterType<MenuService>();
            builder.RegisterType<UIService>();
            builder.RegisterType<ScramblerBoardUI>();
            builder.RegisterType<ReflectorSetup>();
            builder.RegisterType<PlugBoardSetup>();
            builder.RegisterType<RotorsSetup>();
            return builder.Build();
        }
    }
}
