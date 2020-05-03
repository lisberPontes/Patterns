namespace CommandPattern.Commands.Managers
{
    public interface ICommandManager
    {
        void Invoke(ICommand command);
        void UndoLastCommand();
        void UndoAllCommands();
    }
}