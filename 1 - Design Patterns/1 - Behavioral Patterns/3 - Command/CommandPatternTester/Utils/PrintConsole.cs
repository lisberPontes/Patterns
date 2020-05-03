using System;
using System.Text;
using CommandPattern.Repositories;

namespace CommandPatternTester.Utils
{
    internal static class PrintConsole
    {
        public static void PrintShoppingCart(IShoppingCartRepository shoppingCartFakeRepository)
        {
            var totalPrice = 0m;

            var sb = new StringBuilder();

            foreach (var productItem in shoppingCartFakeRepository.GetAll())
            {
                var price = productItem.Product.Price * productItem.Quantity;

                sb.Append($"{productItem.Product.Id.ToString()} ");
                sb.Append($"{ productItem.Product.Price:G} x { productItem.Quantity.ToString()} = ");
                sb.Append($"{ price:G} ");

                Console.WriteLine(sb.ToString());

                totalPrice += price;
            }

            Console.WriteLine($"Total price: ${totalPrice:G}");
        }
    }
}