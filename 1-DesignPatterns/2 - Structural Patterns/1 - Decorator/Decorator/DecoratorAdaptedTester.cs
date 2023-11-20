using System;
using System.Collections.Generic;
using DecoratorAdapted.Component.Concrete;
using DecoratorAdapted.Decorator.Concrete;
using DecoratorAdapted.Decorator.Interface;

namespace Decorator
{
	internal sealed class DecoratorAdaptedTester
	{
		public DecoratorAdaptedTester(Action<DecoratorAdaptedTester> test)
		{
			test.Invoke(this);
		}

		internal void Test()
		{
			Console.WriteLine($"\nExecution of {GetType().Name} \n");

			var compactCar = new CompactCar();

			var decorators = new List<ICarDecorator>
			{
				new NavigationDecorator(),
				new SunroofDecorator(),
				new LeatherSeatsDecorator()
			};

			decorators.ForEach(d => d.Decorate(compactCar));

			Console.WriteLine(compactCar.Description);
			Console.WriteLine($"{compactCar.Price.ToString("C2")}");
		}
	}
}