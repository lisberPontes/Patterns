using System.Linq;
using CommandPattern.Entities;
using System.Collections.Generic;

namespace CommandPattern.Repositories
{
    internal sealed class ProductFakeRepository: IProductRepository
    {
        private Dictionary<int, (IProduct Product, int Stock)> Products { get; }

        public ProductFakeRepository()
        {
            Products = new Dictionary<int, (IProduct Product, int Stock)>
            {
                {1, (new Product(1, "Honda PCX", 3000), 4)},
                {2, (new Product(2, "Iphone XS", 500), 13)},
                {3, (new Product(3, "Galaxy S10", 799), 1)},
                {4, (new Product(4, "Galaxy S20", 1200), 1)}
            };

        }

        public void Add(IProduct product, int stock)
        {
            Products[product.Id] = (product, stock);
        }

        public IProduct FindById(int id)
        {
            return Products.ContainsKey(id) ? Products[id].Product : new NullProduct();
        }

        public bool HasStock(int id)
        {
            if (Products.ContainsKey(id))
            {
                return Products[id].Stock > 0;
            }

            return false;
        }

        public int GetStockFor(int id)
        {
            if (Products.ContainsKey(id))
            {
                return Products[id].Stock;
            }

            return 0;
        }

        public IEnumerable<IProduct> GetAll()
        {
            return Products.Select(p => p.Value.Product);
        }

        public void IncreaseStockById(int id, int amount)
        {
            if (FindById(id) is NullProduct) return;

            Products[id] = (Products[id].Product, Products[id].Stock + amount);
        }

        public void DecreaseStockById(int id, int amount)
        {
            if (FindById(id) is NullProduct) return;

            Products[id] = (Products[id].Product, Products[id].Stock - amount);
        }
    }
}