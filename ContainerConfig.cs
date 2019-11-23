using Autofac;
using BerlinClock.Helpers;
using BerlinClock.TimeEntityMappers;
using BerlinClockUtils;

namespace BerlinClock
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<BerlinClockApp>().SingleInstance();
            RegisterDependencies(containerBuilder);

            return containerBuilder.Build();
        }

        private static void RegisterDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<TimeEntityMapperResolver>().As<ITimeEntityMapperResolver>().SingleInstance();

            containerBuilder.RegisterType<BlinkingTimeEntityMapper>().Keyed<ITimeEntityMapper>(LampsMapperKey.Blink);
            containerBuilder.RegisterType<FourLampsTimeEntityMapper>().Keyed<ITimeEntityMapper>(LampsMapperKey.FourLamps);
            containerBuilder.RegisterType<CustomTimeEntityMapperWithSpecialRecurringRedLamp>().Keyed<ITimeEntityMapper>(LampsMapperKey.Custom);

            containerBuilder.RegisterType<TimeConverter>().As<ITimeConverter>();
            containerBuilder.RegisterType<TimeSpanDeserializer>().As<ITimeSpanDeserializer>();
            containerBuilder.RegisterType<TimePartsValidator>().As<ITimePartsValidator>();
            containerBuilder.RegisterType<LampsRowBuilder>().As<ILampsRowBuilder>();
            containerBuilder.RegisterType<OutputFormatter>().As<IOutputFormatter>();
        }
    }
}