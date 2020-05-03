using System.Linq;
using System.Collections.Generic;

namespace CommandPattern.Commands.Managers
{
    internal sealed class CommandManager: ICommandManager
    {
        private Stack<ICommand> Commands { get; }

        public CommandManager()
        {
            Commands = new Stack<ICommand>();
        }

        public void Invoke(ICommand command)
        {
            if (!command.CanExecute()) return;

            Commands.Push(command);
            command.Execute();
        }

        public void UndoAllCommands()
        {
            while (Commands.Any())
            {
                var command = Commands.Pop();
                command.Undo();
            }
        }

        public void UndoLastCommand()
        {
            if (!Commands.Any()) return;

            var command = Commands.Pop();
            command.Undo();
        }
    }
}