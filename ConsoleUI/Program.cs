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
                builder.RegisterType<ScrambleBoardUI>().As<IUIComponent>();
                builder.RegisterType<PluginBoardUI>().As<IUIComponent>();
                builder.RegisterType<DecodingProcessorUI>().As<IUIComponent>();
                builder.RegisterType<ReflectorSetup>().As<IUIComponent>();
                builder.RegisterType<PluginBoardSetup>().As<IUIComponent>();
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
