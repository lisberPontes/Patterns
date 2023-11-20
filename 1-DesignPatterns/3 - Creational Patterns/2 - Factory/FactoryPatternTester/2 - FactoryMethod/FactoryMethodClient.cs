using FactoryMethod;

namespace FactoryPatternTester.FactoryMethod
{
    internal class FactoryMethodClient
    {
        private IPizzaFactory PizzaFactory { get; }

        public FactoryMethodClient(IPizzaFactory pizzaFactory)
        {
            PizzaFactory = pizzaFactory;
        }

        public void BuildPizza()
        {
            var pizza = PizzaFactory.BuildPizza();
            
            //Act on the created object
            pizza.Bake();
            pizza.Prepare();
            pizza.TurnOff();
        }
    }
}