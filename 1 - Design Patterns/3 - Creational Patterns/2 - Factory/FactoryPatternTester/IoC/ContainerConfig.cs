using Autofac;
using FactoryMethod;
using FactoryMethodPizzaFactory = FactoryMethod.IPizzaFactory;
using AbstractFactoryIPizzaFactory = AbstractFactory.IPizzaFactory;
using AbstractFactoryNeapolitanPizzaThickCrust = AbstractFactory.NeapolitanPizzaThickCrust;

namespace FactoryPatternTester.IoC
{
    internal static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            FactoryMethodDepedencies(builder);
            AbstractFactoryDependencies(builder);
            
            return builder.Build();
        }

        private static void FactoryMethodDepedencies(ContainerBuilder builder)
        {
            builder.RegisterType<NeapolitanPizzaFactory>().As<FactoryMethodPizzaFactory>();
        }

        private static void AbstractFactoryDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<AbstractFactoryNeapolitanPizzaThickCrust>()
                .Named<AbstractFactoryIPizzaFactory>(typeof(AbstractFactoryNeapolitanPizzaThickCrust).Name);
        }
    }
}