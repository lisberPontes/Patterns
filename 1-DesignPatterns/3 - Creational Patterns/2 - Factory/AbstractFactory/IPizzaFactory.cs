using Entities.Crust;
using Entities.Pizza;

namespace AbstractFactory
{
    public interface IPizzaFactory
    {
        IPizza BuildPizza();
        ICrust BuildCrust();
    }
}