using System;

namespace Entities.Crust
{
    public class ThickCrust: ICrust
    {
        public string Name { get; }

        public ThickCrust()
        {
            Name = "Thick";
        }

        public ThickCrust(string name)
        {
            Name = name;
        }

        public void PrepareCrust()
        {
            Console.WriteLine($"Preparing the pizza with a {Name} crust");
        }
    }
}