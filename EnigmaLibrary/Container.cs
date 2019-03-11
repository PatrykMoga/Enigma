using Autofac;

namespace EnigmaLibrary
{
    public static class Container
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DecodingProcessor>();
            builder.RegisterType<ScrambleBoard>().SingleInstance();
            builder.RegisterType<DictionaryRotorProcessor>();
            builder.RegisterType<DictionaryReflector>().As<IReflector>().SingleInstance();
            builder.RegisterType<RotatingService>().SingleInstance();
            builder.RegisterType<PluginBoard>().As<IPluginBoard>().SingleInstance();
            builder.RegisterType<MemoryDataProvider>().SingleInstance();
            builder.RegisterType<MemoryRepository>();
            return builder.Build();
        }
    }
}
