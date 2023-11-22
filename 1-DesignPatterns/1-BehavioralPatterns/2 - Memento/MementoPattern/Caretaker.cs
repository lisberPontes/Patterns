using System.Collections.Generic;
using MementoPattern.Mementos;

namespace MementoPattern
{
    public sealed class Caretaker
    {
        private Stack<IMemento> UndoStack { get; }
        private Stack<IMemento> RedoStack { get; }

        private IMemento CurrentState { get; set; }

        public Caretaker(IMemento memento)
        {
            UndoStack = new Stack<IMemento>();
            RedoStack = new Stack<IMemento>();
            CurrentState = memento;//Set Initial 'Empty' state
        }

        public bool HasChange(IMemento memento)
        {
            return memento.Statement != CurrentState.Statement;
        }

        /// <summary>
        /// Adds memento to UndoStack and updates the current state
        /// </summary>
        /// <param name="memento">The m.</param>
        public void Save(IMemento memento)
        {
            if (!string.IsNullOrWhiteSpace(memento.Statement) &&  HasChange(memento))
            {
                UndoStack.Push(CurrentState);
                CurrentState = memento;
            }
        }

        public bool CanUndo => UndoStack.Count > 0;

        public void Undo()
        {
            if (CanUndo)
            {
                HandleStacks(UndoStack, RedoStack);
            }
        }

        public bool CanRedo => RedoStack.Count > 0;

        public void Redo()
        {
            if (CanRedo)
            {
                HandleStacks(RedoStack, UndoStack);
            }
        }

        private void HandleStacks(Stack<IMemento> fromStack, Stack<IMemento> toStack)
        {
            var previousState = fromStack.Pop();
            toStack.Push(CurrentState);
            CurrentState = previousState;
        }

        /// <summary>
        /// Gets the memento requested from the Stack
        /// </summary>
        /// <returns></returns>
        public IMemento GetMemento()
        {
            return CurrentState;
        }
    }
}