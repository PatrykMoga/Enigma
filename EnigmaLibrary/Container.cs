using Autofac;
using EnigmaLibrary.Boards;
using EnigmaLibrary.Components;
using EnigmaLibrary.Decoding;
using EnigmaLibrary.Repository;

namespace EnigmaLibrary
{
    public static class Container
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DecodingProcessor>().As<IDecodingProcessor>();
            builder.RegisterType<ScrambleBoard>().SingleInstance();
            builder.RegisterType<RotorProcessor>().As<IRotorProcessor>();
            builder.RegisterType<Reflector>().As<IReflector>().SingleInstance();
            builder.RegisterType<RotatingService>().As<IRotatingService>().SingleInstance();
            builder.RegisterType<PluginBoard>().As<IPluginBoard>().SingleInstance();
            builder.RegisterType<MemoryDataProvider>().As<IDataProvider>().SingleInstance();
            builder.RegisterType<MemoryRepository>().As<IMemoryRepository>();
            return builder.Build();
        }
    }
}
