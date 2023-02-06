using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command
{
	public class ButtonCommand : ICommand
	{
		private Action _executeAction;

		public ButtonCommand(Action action)
		{
			_executeAction = action;
		}

		public event EventHandler? CanExecuteChanged;

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
