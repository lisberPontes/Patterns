using DecoratorAdapted.Decorator.Interface;
using DecoratorAdapted.Component.Interface;

namespace DecoratorAdapted.Decorator.Concrete
{
	public sealed class LeatherSeatsDecorator : ICarDecorator
	{
		private const double _leatherSeatsPrice = 2500d;
		public void Decorate(ICar car)
		{
			car.Description = $"{ car.Description} with Leather Seats";
			car.Price = car.Price + _leatherSeatsPrice;
		}
	}
}