using DecoratorClassic.Component.Interface;

namespace DecoratorClassic.Component.Concrete
{
	public sealed class CompactCar : ICar
	{
		private const double _compactCarPrice = 10000.00d;

		public string Description { get; } = "Compact Car";
		public double Price { get; } = _compactCarPrice;

	}
}