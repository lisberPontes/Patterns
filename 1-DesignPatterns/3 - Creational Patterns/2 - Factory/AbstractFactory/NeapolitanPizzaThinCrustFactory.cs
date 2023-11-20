using Entities.Crust;
using Entities.Pizza;

namespace AbstractFactory
{
    public class NeapolitanPizzaThinCrustFactory:IPizzaFactory
    {
        public ICrust BuildCrust()
        {
            var crust = new ThinCrust(typeof(ThinCrust).Name);

            return crust;
        }

        public IPizza BuildPizza()
        {
            var pizza = new NeapolitanPizza(typeof(NeapolitanPizza).Name);

            return pizza;
        }
    }
}