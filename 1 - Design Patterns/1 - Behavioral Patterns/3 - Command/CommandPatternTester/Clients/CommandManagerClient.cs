using System;
using CommandPattern.Commands;
using CommandPattern.Entities;
using System.Collections.Generic;
using CommandPattern.Commands.Managers;

namespace CommandPatternTester.Clients
{
    internal sealed class CommandManagerClient
    {
        private ICommandManager CommandManager { get; }
        
        public CommandManagerClient(ICommandManager commandManager)
        {
            CommandManager = commandManager;
        }


        public void ExecuteCommands(IEnumerable<ICommand> commands, IProduct product)
        {
            foreach (var command in commands)
            {
                CommandManager.Invoke(command);
            }
        }

        public void UndoAllCommands()
        {
            Console.WriteLine("\nUndoing\n");

            CommandManager.UndoAllCommands();
        }


        public void UndoLastCommand()
        {
            Console.WriteLine("\nUndoing Last Command\n");

            CommandManager.UndoLastCommand();
        }
    }
}