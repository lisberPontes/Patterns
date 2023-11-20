using System;

namespace Entities.Crust
{
    public class ThinCrust : ICrust
    {
        public string Name { get; }

        public ThinCrust()
        {
            Name = "Thin";
        }

        public ThinCrust(string name)
        {
            Name = name;
        }

        public void PrepareCrust()
        {
            Console.WriteLine($"Preparing the pizza with a {Name} crust");
        }
    }
}