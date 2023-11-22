namespace MementoPattern.Mementos
{
    public interface IMemento
    {
        /// <summary>
        /// The state we want to persist
        /// </summary>
        /// <value>
        /// The statement.
        /// </value>
        string Statement { get; }

    }
}