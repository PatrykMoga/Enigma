using Autofac;
using ConsoleUI.Setups;
using ConsoleUI.UIComponents;

namespace ConsoleUI
{
    public static class ConsoleContainer
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();            
            builder.RegisterType<UIService>();
            builder.RegisterType<ScramblerBoardUI>();
            builder.RegisterType<ReflectorSetup>();
            builder.RegisterType<PlugBoardSetup>();
            builder.RegisterType<RotorsSetup>();
            return builder.Build();
        }
    }
}
