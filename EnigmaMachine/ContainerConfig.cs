using Autofac;
using EnigmaMachine.Machine;
using EnigmaMachine.Repository;

namespace EnigmaMachine
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Enigma>();
            builder.RegisterType<DecodingProcessor>();
            builder.RegisterType<ScramblerBoard>().SingleInstance();
            builder.RegisterType<ScramblerBoardService>();
            builder.RegisterType<RotorProcessor>();
            builder.RegisterType<DictionaryReflector>();
            builder.RegisterType<RotatingService>();
            builder.RegisterType<PlugBoardService>();

            builder.RegisterType<MemoryDataProvider>();
            builder.RegisterType<MemoryRepository>();

            return builder.Build();
        }
    }
}
