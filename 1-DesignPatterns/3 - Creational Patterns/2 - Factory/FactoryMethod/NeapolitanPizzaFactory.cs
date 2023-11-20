using Entities.Pizza;

namespace FactoryMethod
{
    public class NeapolitanPizzaFactory : IPizzaFactory
    {
        public IPizza BuildPizza()
        {
            var pizza = new NeapolitanPizza(typeof(NeapolitanPizza).Name);

            return pizza;
        }
    }
}