using CommandPattern.Entities;
using CommandPattern.Repositories;

namespace CommandPattern.Commands.Carts
{
    internal sealed class AddToCartCommand: ICommand
    {
        private IShoppingCartRepository ShoppingCartFakeRepository { get; }
        private IProductRepository ProductFakeRepository { get; }
        private IProduct Product { get; }

        public AddToCartCommand(IShoppingCartRepository shoppingCartFakeRepository,
            IProductRepository productRepository,
            IProduct product)
        {
            ShoppingCartFakeRepository = shoppingCartFakeRepository;
            ProductFakeRepository = productRepository;
            Product = product ?? new NullProduct();
        }

        public void Execute()
        {
            if (Product is NullProduct) return;

            ProductFakeRepository.DecreaseStockById(Product.Id, 1);

            ShoppingCartFakeRepository.Add(Product);
        }

        public bool CanExecute()
        {
            if (Product is NullProduct) return false;

            return ProductFakeRepository.HasStock(Product.Id);
        }

        public void Undo()
        {
            if (Product is NullProduct) return;

            var groupedProduct = ShoppingCartFakeRepository.Get(Product.Id);

            ProductFakeRepository.IncreaseStockById(Product.Id, groupedProduct.Quantity);

            ShoppingCartFakeRepository.RemoveAll(Product.Id);
        }
    }
}