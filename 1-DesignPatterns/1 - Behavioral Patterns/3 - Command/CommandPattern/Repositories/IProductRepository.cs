using CommandPattern.Entities;
using System.Collections.Generic;

namespace CommandPattern.Repositories
{
    public interface IProductRepository
    {
        void Add(IProduct product, int stock);
        IProduct FindById(int id);
        bool HasStock(int id);
        int GetStockFor(int id);
        IEnumerable<IProduct> GetAll();
        void IncreaseStockById(int id, int amount);
        void DecreaseStockById(int id, int amount);
    }
}