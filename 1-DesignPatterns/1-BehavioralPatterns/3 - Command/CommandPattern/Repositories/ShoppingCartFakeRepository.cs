using CommandPattern.Entities;
using System.Collections.Generic;

namespace CommandPattern.Repositories
{
    internal sealed class ShoppingCartFakeRepository: IShoppingCartRepository
    {
        public Dictionary<int, (IProduct Product, int Quantity)> GroupedProducts  = new Dictionary<int, (IProduct Product, int Quantity)>();

        public (IProduct Product, int Quantity) Get(int id)
        {
            return GroupedProducts.ContainsKey(id) ? GroupedProducts[id] : (new NullProduct(), default);
        }

        public IEnumerable<(IProduct Product, int Quantity)> GetAll()
        {
            return GroupedProducts.Values;
        }

        public void Add(IProduct product)
        {
            if (GroupedProducts.ContainsKey(product.Id))
            {
                IncreaseQuantity(product.Id);
            }
            else
            {
                GroupedProducts[product.Id] = (product, 1);
            }
        }

        public void RemoveAll(int id)
        {
            GroupedProducts.Remove(id);
        }

        public void IncreaseQuantity(int id)
        {
            if (!GroupedProducts.ContainsKey(id)) return;

            var groupedProduct = GroupedProducts[id];
            GroupedProducts[id] = (groupedProduct.Product, groupedProduct.Quantity + 1);
        }

        public void DecreaseQuantity(int id)
        {
            if (!GroupedProducts.ContainsKey(id)) return;

            var groupedProduct = GroupedProducts[id];
            GroupedProducts[id] = (groupedProduct.Product, groupedProduct.Quantity - 1);
        }
    }
}