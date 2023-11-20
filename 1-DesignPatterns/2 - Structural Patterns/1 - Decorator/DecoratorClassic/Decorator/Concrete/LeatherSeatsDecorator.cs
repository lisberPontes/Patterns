using DecoratorClassic.Component.Interface;
using DecoratorClassic.Decorator.Interface;

namespace DecoratorClassic.Decorator.Concrete
{
	public sealed class LeatherSeatsDecorator : ICarDecorator
	{
		private const double _leatherSeatsPrice = 2500d;
		private ICar Car { get; }

		public string Description => $"{Car.Description} with Leather Seats";

		public double Price => Car.Price + _leatherSeatsPrice;

		public LeatherSeatsDecorator(ICar car)
		{
			Car = car;
		}
	}
}