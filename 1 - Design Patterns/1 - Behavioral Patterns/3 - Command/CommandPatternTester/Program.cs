using System;
using CommandPattern.Commands;
using CommandPattern.Entities;
using CommandPatternTester.Utils;
using System.Collections.Generic;
using CommandPattern.Repositories;
using CommandPatternTester.Clients;
using CommandPattern.Commands.Carts;
using CommandPattern.Commands.Managers;

namespace CommandPatternTester
{
    internal class Program
    {
        private static IShoppingCartRepository ShoppingCartRepository { get; }= new ShoppingCartFakeRepository();
        private static IProductRepository ProductRepository { get; }= new ProductFakeRepository();
        private static IProduct Product { get; } = ProductRepository.FindById(1);

        private static IEnumerable<ICommand> CommandsToBeExecuted
        {
            get
            {
                yield return new AddToCartCommand(ShoppingCartRepository, ProductRepository, Product);
                yield return new IncreaseQuantityCommand(ShoppingCartRepository, ProductRepository, Product);
            }
        }

        static void Main(string[] args)
        {
            var commandManagerClient = new CommandManagerClient(new CommandManager());

            commandManagerClient.ExecuteCommands(CommandsToBeExecuted, Product);
            PrintConsole.PrintShoppingCart(ShoppingCartRepository);

            commandManagerClient.UndoLastCommand();

            PrintConsole.PrintShoppingCart(ShoppingCartRepository);
            Console.ReadLine();
        }
    }
}