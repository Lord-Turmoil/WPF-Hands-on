using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Notify
{
	public class MainViewModel : MyViewModelBase
	{
		private string? _name;

		public CommandForward ClickCommand { get; set; }

        public MainViewModel()
        {
			Name = "Hello there!";
			ClickCommand = new CommandForward(OnClickAction);
        }

        public string Name
		{
			get { return _name; }
			set
			{
				_name = value;

				// argument should be the value that the UI binds.
				// OnPropertyChanged("Name");
				OnPropertyChanged();	// Auto filled by complier due to [CallerMemberName]
			}
		}

		public void OnClickAction()
		{
			Name = "Click OK";
			MessageBox.Show("You have clicked the button.");
			Name = "General Kenobi!";
		}
	}
}