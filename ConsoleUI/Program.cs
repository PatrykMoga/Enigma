using Autofac;
using ConsoleUI.Menu;
using ConsoleUI.Setups;
using ConsoleUI.UIComponents;
using EnigmaLibrary;
using System;

namespace ConsoleUI
{
    internal static class Program
    {
        private static void Main()
        {
            var container = Container.Configure();
            using (var scope = container.BeginLifetimeScope(builder =>
            {
                builder.RegisterType<Enigma>();
                builder.RegisterType<MenuService>();
                builder.RegisterType<UIService>();
                builder.RegisterType<ScramblerBoardUI>();
                builder.RegisterType<ReflectorSetup>();
                builder.RegisterType<PlugBoardSetup>();
                builder.RegisterType<RotorsSetup>();
            }))
            {
                var app = scope.Resolve<Enigma>();
                app.Initialize();
            }
        }
    }
}
