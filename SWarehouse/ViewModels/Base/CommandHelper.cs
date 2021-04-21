using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SWarehouse.ViewModels.Base
{
    public class CommandHelper<T> : ICommand
    {
        private readonly Predicate<T> _canExecute;
        private readonly Action<T> _execute;

        public CommandHelper(Predicate<T> canExecute, Action<T> execute)
        {
            _canExecute = canExecute;
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? false : _canExecute((T)parameter);
        }

        public void Execute(object parameter) => _execute((T)parameter);

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
    public class CommandHelper : ICommand
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action _execute;

        public CommandHelper(Action execute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");
            _execute = execute;
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute((object)parameter);
        }
        public void Execute(object parameter)
        {
            _execute();
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
