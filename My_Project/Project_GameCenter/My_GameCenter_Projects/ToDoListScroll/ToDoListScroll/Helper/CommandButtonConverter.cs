using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToDoListScroll.Helper
{
    public class CommandButtonConverter : ICommand
    {
        private Action mAction;

        public event EventHandler? CanExecuteChanged;

        public CommandButtonConverter(Action action)
        {
            mAction = action;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            mAction();
        }
    }
}
