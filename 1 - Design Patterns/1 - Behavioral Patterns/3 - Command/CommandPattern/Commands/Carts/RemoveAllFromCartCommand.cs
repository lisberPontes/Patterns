using System;
using System.Linq;
using CommandPattern.Entities;
using CommandPattern.Repositories;

namespace CommandPattern.Commands.Carts
{
    internal sealed class RemoveAllFromCartCommand: ICommand
    {
        private IShoppingCartRepository ShoppingCartFakeRepository { get; }
        private IProductRepository ProductFakeRepository { get; }
        private IProduct Product { get; }

        public RemoveAllFromCartCommand(IShoppingCartRepository shoppingCartFakeRepository,
            IProductRepository productRepository,
            IProduct product)
        {
            ShoppingCartFakeRepository = shoppingCartFakeRepository;
            ProductFakeRepository = productRepository;
            Product = product ?? new NullProduct(); ;
        }

        public bool CanExecute()
        {
            return ShoppingCartFakeRepository.GetAll().Any();
        }

        public void Execute()
        {
            var productsLocalCopy = ShoppingCartFakeRepository.GetAll().ToList(); 

            foreach (var productLocalCopy in productsLocalCopy)
            {
                ProductFakeRepository.IncreaseStockById(productLocalCopy.Product.Id, productLocalCopy.Quantity);

                ShoppingCartFakeRepository.RemoveAll(productLocalCopy.Product.Id);
            }
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}