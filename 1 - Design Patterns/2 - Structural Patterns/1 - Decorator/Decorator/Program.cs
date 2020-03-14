using System;

namespace Decorator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var decoratorClassicTester = new DecoratorClassicTester(d => d.Test());
			var decoratorAdaptedTester = new DecoratorAdaptedTester(d => d.Test());

			Console.ReadKey();
		}
	}
}