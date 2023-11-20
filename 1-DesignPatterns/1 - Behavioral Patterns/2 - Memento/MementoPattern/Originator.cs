using MementoPattern.Mementos;

namespace MementoPattern
{
    internal sealed class Originator
    {
        /// <summary>
        /// This is the state that we want to 'save/restore' and we don't want to expose
        /// </summary>
        /// <value>
        /// The statement.
        /// </value>
        private string Statement { get; set; }

        /// <summary>
        /// Sets the value for the Statement
        /// </summary>
        /// <param name="newStatement">The new statement.</param>
        public void Set(string newStatement)
        {
            Statement = newStatement;
        }

        /// <summary>
        /// Creates a new Memento with a new Statement
        /// </summary>
        /// <returns></returns>
        public IMemento CreateMemento()
        {
            return new Memento(Statement);
        }

        /// <summary>
        /// Gets the Statement currently stored in memento
        /// </summary>
        /// <param name="memento">The memento.</param>
        /// <returns></returns>
        public string SetMemento(IMemento memento)
        {
            Statement = memento.Statement;

            return Statement;
        }
    }
}