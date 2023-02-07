using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
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
			MvvmClickCommand = new RelayCommand<string>(OnMvvmClickAction);
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

		public RelayCommand<string> MvvmClickCommand { get; }

		public void OnMvvmClickAction(string content)
		{
			Line = "Click OK";
			MessageBox.Show(content);
			Line = "You fool!";

			// Token must correspond each other.
			Messenger.Default.Send<string>(content, "Token");
		}
	}
}
