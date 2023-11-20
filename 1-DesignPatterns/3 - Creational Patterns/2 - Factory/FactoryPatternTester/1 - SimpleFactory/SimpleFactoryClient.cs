
using SimpleFactory;

namespace FactoryPatternTester.SimpleFactory
{
    internal class SimpleFactoryClient
    {
        public void BuildPizza(string pizzaType)
        {
            var pizzaFactory = new PizzaFactory();
            var pizza = pizzaFactory.BuildPizza(pizzaType);
            //Act on the created object
            pizza.Bake();
            pizza.Prepare();
            pizza.TurnOff();

        }
    }
}