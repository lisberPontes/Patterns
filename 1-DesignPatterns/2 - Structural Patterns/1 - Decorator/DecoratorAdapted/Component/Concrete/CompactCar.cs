using DecoratorAdapted.Component.Interface;

namespace DecoratorAdapted.Component.Concrete
{
	public sealed class CompactCar : ICar
	{
		private const double _compactCarPrice = 10000.00d;

		public string Description { get; set; } = "Compact Car";
		public double Price { get; set; } = _compactCarPrice;

	}
}