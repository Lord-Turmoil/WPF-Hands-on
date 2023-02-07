using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM
{
	public class MainViewModel : ObservableObject
	{
		private string? _displayText { get; set; }
		public string DisplayText
		{
			get { return _displayText; }
			set
			{
				_displayText = value;
				OnPropertyChanged();
			}
		}

		public RelayCommand<string>? ClickCommand { get; }

		public MainViewModel()
		{
			DisplayText = "Nothing...";
			ClickCommand = new RelayCommand<string>(OnButtonClicked);
		}

		public void OnButtonClicked(string? content)
		{
			MessageBox.Show(content);
			DisplayText = "You have clicked the button.";
			WeakReferenceMessenger.Default.Send<string, string>((content == null) ? "null" : content, "Token");
		}
	}
}
