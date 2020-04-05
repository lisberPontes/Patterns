using System;
using Autofac;
using Entities.Pizza;
using FactoryPatternTester.IoC;
using FactoryPatternTester.FactoryMethod;
using FactoryPatternTester.SimpleFactory;
using FactoryPatternTester.AbstractFactory;
using FactoryMethodPizzaFactory = FactoryMethod.IPizzaFactory;
using AbstractFactoryPizzaFactory = AbstractFactory.IPizzaFactory;
using AbstractFactoryNeapolitanPizzaThickCrust = AbstractFactory.NeapolitanPizzaThickCrust;


namespace FactoryPatternTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            Console.WriteLine("\n1- SimpleFactory");

            //1 - SimpleFactory
            var simpleFactoryClient = new SimpleFactoryClient();
            simpleFactoryClient.BuildPizza(typeof(NeapolitanPizza).Name);

            Console.WriteLine("\n2- FactoryMethod");

            //2 - FactoryMethod
            
            using (var scope = container.BeginLifetimeScope())
            {
                var factory = scope.Resolve<FactoryMethodPizzaFactory>();
                var factoryMethodClient = new FactoryMethodClient(factory);
                factoryMethodClient.BuildPizza();
            }

            Console.WriteLine("\n3 - AbstractFactory");

            //3 - AbstractFactory
            using (var scope = container.BeginLifetimeScope())
            {
                var factory = scope.ResolveNamed<AbstractFactoryPizzaFactory>(typeof(AbstractFactoryNeapolitanPizzaThickCrust).Name);
                var factoryMethodClient = new AbstractFactoryClient(factory);
                factoryMethodClient.BuildPizza();
            }

            Console.ReadLine();
        }
    }
}