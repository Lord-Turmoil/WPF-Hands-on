using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notify
{
	public class CommandForward : ICommand
	{
		public event EventHandler? CanExecuteChanged;

		private Action _executeAction;

        public CommandForward(Action action)
        {
			_executeAction = action;
        }

        public bool CanExecute(object? parameter)
		{
			return true;
		}

		public void Execute(object? parameter)
		{
			_executeAction();
		}
	}
}
