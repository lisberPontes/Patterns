using Entities.Pizza;

namespace FactoryMethod
{
    public class NewYorkerPizzaFactory: IPizzaFactory
    {
        public IPizza BuildPizza()
        {
            var pizza = new NeapolitanPizza(typeof(NewYorkerPizza).Name);

            return pizza;
        }
    }
}