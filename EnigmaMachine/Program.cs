using Autofac;
using EnigmaMachine.Machine;

namespace EnigmaMachine
{
    internal static class Program
    {
        private static void Main()
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<Enigma>();
                app.Initialize();
            }
        }
    }
}
