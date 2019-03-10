using Autofac;

namespace EnigmaLibrary
{
    public static class Container
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DecodingProcessor>();
            builder.RegisterType<ScramblerBoard>().SingleInstance();
            builder.RegisterType<DictionaryRotorProcessor>();
            builder.RegisterType<DictionaryReflector>().SingleInstance();
            builder.RegisterType<RotatingService>().SingleInstance();
            builder.RegisterType<PlugBoard>().SingleInstance();
            builder.RegisterType<MemoryDataProvider>().SingleInstance();
            builder.RegisterType<MemoryRepository>();
            return builder.Build();
        }
    }
}
