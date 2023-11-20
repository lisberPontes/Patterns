using System;
using System.Linq;
using Entities.Pizza;
using System.Collections.Generic;

namespace SimpleFactory
{
    public class PizzaFactory
    {
        private Dictionary<string, Type> Pizzas { get; set; }

        public PizzaFactory()
        {
            LoadIPizzaTypes();
        }

        public IPizza BuildPizza(string pizzaType)
        {
            Type t = GetTypeToCreate(pizzaType);

            return Activator.CreateInstance(t) as IPizza;
        }

        private Type GetTypeToCreate(string pizzaType)
        {
            foreach (var pizza in Pizzas)
            {
                if (pizza.Key.Contains(pizzaType))
                {
                    return Pizzas[pizza.Key];
                }
            }
            return null;
        }


        private void LoadIPizzaTypes()
        {
            Pizzas = new Dictionary<string, Type>();

            var entityTypesAssembly = AppDomain.CurrentDomain.GetAssemblies()
                .First(a => a.FullName.Contains("Entities")).GetTypes();

            foreach (Type type in entityTypesAssembly)
            {
                if (type.GetInterface(typeof(IPizza).ToString()) != null)
                {
                    Pizzas.Add(type.Name, type);
                }
            }
        }
    }
}