using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using MementoPattern;
using MementoPattern.Mementos;
using Tester.Commands;


namespace Tester.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Caretaker Caretaker { get; }
        private Originator Originator { get; }
        public int _currentStatementCount = 1;
        public int CurrentStatementCount
        {
            get => _currentStatementCount;
            set
            {
                _currentStatementCount = value;
                UndoCommand.RaiseCanExecuteChanged();
                RedoCommand.RaiseCanExecuteChanged();
                OnPropertyChanged();
            }
        }

        public string _currentStatement;
        public string CurrentStatement
        {
            get => _currentStatement;
            set
            {
                if (value != _currentStatement)
                {
                    _currentStatement = value;
                    SaveCommand.RaiseCanExecuteChanged();
                    UndoCommand.RaiseCanExecuteChanged();
                    RedoCommand.RaiseCanExecuteChanged();
                    OnPropertyChanged();
                }
            }
        }

        public RelayCommandBase SaveCommand { get; }
        public RelayCommandBase UndoCommand { get; }
        public RelayCommandBase RedoCommand { get; }

        public MainWindowViewModel()
        {
            Caretaker = new Caretaker(new NullMemento());
            Originator = new Originator();

            SaveCommand = new RelayCommandBase(OnSave, CanSave);
            UndoCommand = new RelayCommandBase(OnUndo, CanUndo);
            RedoCommand = new RelayCommandBase(OnRedo, CanRedo);
        }

        private void OnSave()
        {
            Originator.Set(CurrentStatement);
            var updatedStateMemento = Originator.CreateMemento();
            if (Caretaker.HasChange(updatedStateMemento))
            {
                Caretaker.Save(updatedStateMemento);
                CurrentStatementCount++;
            }
        }

        private bool CanSave()
        {
            return !string.IsNullOrWhiteSpace(CurrentStatement);
        }

        private void OnUndo()
        {
            if (CanUndo())
            {
                CurrentStatementCount--;

                Caretaker.Undo();
                var storedMemento = Caretaker.GetMemento();
                CurrentStatement = Originator.SetMemento(storedMemento);
            }
        }

        private bool CanUndo()
        {
            return Caretaker.CanUndo;
        }

        private void OnRedo()
        {
            if (CanRedo())
            {
                CurrentStatementCount++;

                Caretaker.Redo();
                var storedMemento = Caretaker.GetMemento();
                CurrentStatement = Originator.SetMemento(storedMemento);
            }
        }

        private bool CanRedo()
        {
            return Caretaker.CanRedo;
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }


    [AttributeUsage(AttributeTargets.Method)]
    public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
    {
        public NotifyPropertyChangedInvocatorAttribute() { }
        public NotifyPropertyChangedInvocatorAttribute([NotNull] string parameterName)
        {
            ParameterName = parameterName;
        }

        public string ParameterName { get; }
    }
}
