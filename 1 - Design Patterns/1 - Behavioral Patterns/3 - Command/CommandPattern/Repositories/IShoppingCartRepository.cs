using CommandPattern.Entities;
using System.Collections.Generic;

namespace CommandPattern.Repositories
{
    public interface IShoppingCartRepository
    {
        (IProduct Product, int Quantity) Get(int id);
        IEnumerable<(IProduct Product, int Quantity)> GetAll();
        void Add(IProduct product);
        void RemoveAll(int id);
        void IncreaseQuantity(int id);
        void DecreaseQuantity(int id);
    }
}