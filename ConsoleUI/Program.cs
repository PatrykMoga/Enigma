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
                builder.RegisterType<ScrambleBoardUI>().As<BetterIUIComponent>();
                builder.RegisterType<PluginBoardUI>().As<BetterIUIComponent>();
                builder.RegisterType<DecodingProcessorUI>().As<BetterIUIComponent>();
                //builder.RegisterType<ReflectorSetups>().As<IUIComponent>();
                //builder.RegisterType<PluginBoardSetups>().As<IUIComponent>();
                //builder.RegisterType<RotorsSetups>().As<IUIComponent>();
                builder.RegisterType<AddConnection>().As<BetterIUIComponent>();
                builder.RegisterType<ResetConnection>().As<BetterIUIComponent>();
                builder.RegisterType<SetReflector>().As<BetterIUIComponent>();
                builder.RegisterType<SetRotors>().As<BetterIUIComponent>();
                builder.RegisterType<SetPositions>().As<BetterIUIComponent>();
                builder.RegisterType<ResetPositions>().As<BetterIUIComponent>();
                builder.RegisterType<Exit>().As<BetterIUIComponent>();
            }))
            {
                var app = scope.Resolve<ConsoleUI>();
                app.Initialize();
            }
        }
    }
}
