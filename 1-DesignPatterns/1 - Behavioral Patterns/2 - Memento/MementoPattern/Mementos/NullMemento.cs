namespace MementoPattern.Mementos
{
    internal sealed class NullMemento: IMemento
    {
        /// <summary>
        /// Null Object Pattern implementation
        /// </summary>
        /// <value>
        /// The statement.
        /// </value>
        public string Statement { get; } 

        public NullMemento()
        {
            Statement = string.Empty;
        }
    }
}