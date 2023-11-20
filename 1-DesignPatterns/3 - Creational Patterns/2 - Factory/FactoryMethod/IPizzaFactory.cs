using Entities.Pizza;

namespace FactoryMethod
{
    public interface IPizzaFactory
    {
        IPizza BuildPizza();
    }
}