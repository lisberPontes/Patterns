using System;
using DecoratorClassic.Component.Concrete;
using DecoratorClassic.Decorator.Concrete;
using DecoratorClassic.Component.Interface;


namespace Decorator
{
	internal sealed class DecoratorClassicTester
	{

		public DecoratorClassicTester(Action<DecoratorClassicTester> test)
		{
			test.Invoke(this);
		}
		internal void Test()
		{
			Console.WriteLine($"\nExecution of {GetType().Name} \n");

			ICar compactCar = new CompactCar();
			compactCar = new NavigationDecorator(compactCar);
			compactCar = new SunroofDecorator(compactCar);
			compactCar = new LeatherSeatsDecorator(compactCar);

			Console.WriteLine(compactCar.Description);
			Console.WriteLine($"{compactCar.Price.ToString("C2")}");


			// -------------------- OR --------------------

			//var compactCar2 = new LeatherSeatsDecorator(new SunroofDecorator(new NavigationDecorator(new CompactCar())));

			//Console.WriteLine(compactCar2.Description);
			//Console.WriteLine($"{compactCar.Price.ToString("C2")}");

		}
	}
}