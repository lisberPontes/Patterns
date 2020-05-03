using CommandPattern.Entities;
using CommandPattern.Repositories;

namespace CommandPattern.Commands.Carts
{
    internal sealed class DecreaseQuantityCommand : ICommand
    {
        private IShoppingCartRepository ShoppingCartFakeRepository { get; }
        private IProductRepository ProductFakeRepository { get; }
        private IProduct Product { get; }

        public DecreaseQuantityCommand(IShoppingCartRepository shoppingCartFakeRepository,
            IProductRepository productRepository,
            IProduct product)
        {
            ShoppingCartFakeRepository = shoppingCartFakeRepository;
            ProductFakeRepository = productRepository;
            Product = product ?? new NullProduct(); ;
        }

        public void Execute()
        {
            ProductFakeRepository.DecreaseStockById(Product.Id, 1);
            ShoppingCartFakeRepository.IncreaseQuantity(Product.Id);
        }

        public bool CanExecute()
        {
            return (ProductFakeRepository.GetStockFor(Product.Id)!=0);
        }

        public void Undo()
        {
            ProductFakeRepository.DecreaseStockById(Product.Id, 1);
            ShoppingCartFakeRepository.IncreaseQuantity(Product.Id);
        }
    }
}