using DecoratorClassic.Component.Interface;
using DecoratorClassic.Decorator.Interface;

namespace DecoratorClassic.Decorator.Concrete
{
	public sealed class SunroofDecorator : ICarDecorator
	{
		private const double _sunroofPrice = 2500d;
		private ICar Car { get; }

		public string Description => $"{Car.Description} with Sunroof";

		public double Price => Car.Price + _sunroofPrice;


		public SunroofDecorator(ICar car)
		{
			Car = car;
		}
	}

}