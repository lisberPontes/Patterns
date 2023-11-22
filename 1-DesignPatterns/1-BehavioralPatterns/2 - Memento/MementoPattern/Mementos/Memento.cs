namespace MementoPattern.Mementos
{
    public sealed class Memento: IMemento
    {
        public string Statement { get; }

        public Memento(string statementSave)
        {
            Statement = statementSave;
        }
       
    }
}