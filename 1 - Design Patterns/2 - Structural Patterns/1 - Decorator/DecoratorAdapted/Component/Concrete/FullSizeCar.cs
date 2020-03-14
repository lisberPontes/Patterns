using DecoratorAdapted.Component.Interface;

namespace DecoratorAdapted.Component.Concrete
{
	public sealed class FullSizeCar : ICar
	{
		private const double _compactCarPrice = 30000.00d;

		public string Description { get; set; } = "FullSize Car";
		public double Price { get; set; } = _compactCarPrice;

	}
}