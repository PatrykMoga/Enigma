using Autofac;
using ConsoleUI.Setups;
using ConsoleUI.UIComponents;
using EnigmaLibrary;

namespace ConsoleUI
{
    internal static class Program
    {
        private static void Main()
        {
            var container = Container.Configure();
            using (var scope = container.BeginLifetimeScope(builder =>
            {
                builder.RegisterType<ConsoleUI>();
                builder.RegisterType<UIService>();
                builder.RegisterType<ScramblerBoardUI>().As<IUIComponent>();
                builder.RegisterType<PlugBoardUI>().As<IUIComponent>();
                builder.RegisterType<DecodingProcessorUI>().As<IUIComponent>();
                builder.RegisterType<ReflectorSetup>().As<IUIComponent>();
                builder.RegisterType<PlugBoardSetup>().As<IUIComponent>();
                builder.RegisterType<RotorsSetup>().As<IUIComponent>();
                builder.RegisterType<AdditionalSetups>().As<IUIComponent>();
            }))
            {
                var app = scope.Resolve<ConsoleUI>();
                app.Initialize();
            }
        }
    }
}
