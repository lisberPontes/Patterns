using DecoratorAdapted.Decorator.Interface;
using DecoratorAdapted.Component.Interface;

namespace DecoratorAdapted.Decorator.Concrete
{
	public sealed class SunroofDecorator : ICarDecorator
	{
		private const double _sunroofPrice = 2500d;
		public void Decorate(ICar car)
		{
			car.Description = $"{ car.Description} with Sunroof";
			car.Price = car.Price + _sunroofPrice;
		}
	}
}