using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Command
{
	public class MainViewModel
	{
		public MainViewModel()
		{
			ShowCommand = new ButtonCommand(Show);
		}

		// Must be public, not private.
		public ButtonCommand ShowCommand { get; set; }
		
		public void Show()
		{
			MessageBox.Show("You have clicked the button.");
		}
	}
}
