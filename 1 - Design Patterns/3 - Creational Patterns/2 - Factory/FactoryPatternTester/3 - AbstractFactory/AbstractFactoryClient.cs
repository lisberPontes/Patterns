using AbstractFactory;

namespace FactoryPatternTester.AbstractFactory
{
    internal class AbstractFactoryClient
    {
        private IPizzaFactory PizzaFactory { get; }

        public AbstractFactoryClient(IPizzaFactory pizzaFactory)
        {
            PizzaFactory = pizzaFactory;
        }

        public void BuildPizza()
        {
            var pizza = PizzaFactory.BuildPizza();
            var crust = PizzaFactory.BuildCrust();

            //Act on the family of created objects
            pizza.Bake();
            crust.PrepareCrust();
            pizza.Prepare();
            pizza.TurnOff();
        }
    }
}
