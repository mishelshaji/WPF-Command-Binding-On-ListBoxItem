using System;
using System.Windows.Input;

namespace WpfCommandBindingOnListItem.CustomCommands
{
    public class RelayCommand: ICommand
    {
        private Action<object> _handler;
        private Predicate<object> _canExecute;

        public RelayCommand(Action<object> handler, Predicate<object> canExecute)
        {
            _handler = handler;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _handler(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}