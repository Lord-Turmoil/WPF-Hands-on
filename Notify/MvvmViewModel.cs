using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Notify
{
	public class MvvmViewModel : ViewModelBase
	{
		private string? _line;

		public MvvmViewModel()
		{
			Line = "Your move.";
			MvvmClickCommand = new RelayCommand(OnMvvmClickAction);
		}

		public string Line
		{
			get { return _line; }
			set
			{
				_line = value;
				RaisePropertyChanged();
			}
		}

		public RelayCommand MvvmClickCommand { get; }

		public void OnMvvmClickAction()
		{
			Line = "Click OK";
			MessageBox.Show("Clicked the button, you have.");
			Line = "You fool!";
		}
	}
}
