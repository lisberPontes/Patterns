namespace MementoPattern.Mementos
{
    internal interface IMemento
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