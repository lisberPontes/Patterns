using DecoratorClassic.Component.Interface;

namespace DecoratorClassic.Component.Concrete
{
	public sealed class FullSizeCar : ICar
	{
		private const double _compactCarPrice = 30000.00d;

		public string Description { get; } = "FullSize Car";
		public double Price { get; } = _compactCarPrice;

	}
}