using Entities.Crust;
using Entities.Pizza;

namespace AbstractFactory
{
    public class NeapolitanPizzaThickCrustFactory : IPizzaFactory
    {
        public ICrust BuildCrust()
        {
            var crust = new ThickCrust(typeof(ThickCrust).Name);

            return crust;
        }

        public IPizza BuildPizza()
        {
            var pizza = new NeapolitanPizza(typeof(NeapolitanPizza).Name);

            return pizza;
        }
    }
}