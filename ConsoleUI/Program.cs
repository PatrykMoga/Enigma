using Autofac;
using ConsoleUI.Setups;
using ConsoleUI.UIComponents;
using ConsoleUI.UIServiceComponents;
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
                builder.RegisterType<UIService>().As<IUIService>();
                builder.RegisterType<ScrambleBoardUI>().As<IUIComponent>();
                builder.RegisterType<PluginBoardUI>().As<IUIComponent>();
                builder.RegisterType<DecodingProcessorUI>().As<IUIComponent>();
                builder.RegisterType<SetRotors>().As<IUIComponent>();
                builder.RegisterType<SetRotorsPositions>().As<IUIComponent>();
                builder.RegisterType<ResetRotorsPositions>().As<IUIComponent>();
                builder.RegisterType<SetReflector>().As<IUIComponent>();
                builder.RegisterType<AddPluginConnection>().As<IUIComponent>();
                builder.RegisterType<ResetPluginsConnection>().As<IUIComponent>();              
                builder.RegisterType<ExitCommand>().As<IUIComponent>();
            }))
            {
                var app = scope.Resolve<ConsoleUI>();
                app.Initialize();
            }
        }
    }
}
