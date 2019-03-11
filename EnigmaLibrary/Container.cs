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
            builder.RegisterType<RotorProcessor>().As<IRotorProcessor>();           
            builder.RegisterType<Reflector>().As<IReflector>().SingleInstance();
            builder.RegisterType<RotatingService>().SingleInstance();
            builder.RegisterType<PluginBoard>().SingleInstance();
            builder.RegisterType<MemoryDataProvider>().SingleInstance();
            builder.RegisterType<MemoryRepository>().As<IMemoryRepository>();
            return builder.Build();
        }
    }
}
