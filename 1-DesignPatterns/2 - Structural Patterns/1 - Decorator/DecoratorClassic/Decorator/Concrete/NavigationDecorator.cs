using DecoratorClassic.Component.Interface;
using DecoratorClassic.Decorator.Interface;

namespace DecoratorClassic.Decorator.Concrete
{
	public sealed class NavigationDecorator : ICarDecorator
	{
		private const double _navigationPrice = 5000d;
		private ICar Car { get; }

		public string Description => $"{Car.Description} with Navigation";

		public double Price => Car.Price + _navigationPrice;

		public NavigationDecorator(ICar car)
		{
			Car = car;
		}
	}
}