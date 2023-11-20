using DecoratorAdapted.Decorator.Interface;
using DecoratorAdapted.Component.Interface;

namespace DecoratorAdapted.Decorator.Concrete
{
	public sealed class NavigationDecorator : ICarDecorator
	{
		private const double _navigationPrice = 5000d;
		public void Decorate(ICar car)
		{
			car.Description = $"{ car.Description} with Navigation";
			car.Price = car.Price + _navigationPrice;
		}
	}
}