using System;

namespace Entities.Pizza
{
    public class NewYorkerPizza:IPizza
    {
        public string Name { get; }

        public NewYorkerPizza()
        {
            Name = "NewYorkerPizza";
        }

        public NewYorkerPizza(string name)
        {
            Name = name;
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing the {Name} Pizza!");
        }

        public void TurnOff()
        {
            Console.WriteLine($"The {Name} Pizza has been turned off, Is Ready!!!");
        }

        public void Bake()
        {
            Console.WriteLine($"The {Name} Pizza is being baking....");
        }
    }
}