using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Binding
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.DataContext = new Binder()
			{
				Name = "Binder"
			};
		}

		private void OnSliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			box.Text = slider.Value.ToString();
        }

		private void OnTextBoxChanged(object sender, TextChangedEventArgs e)
		{
			// Parse text to number.
			// out means create a variable and then pass it by reference
			if (double.TryParse(box.Text, out double value))
				slider.Value = value;
			else
				slider.Value = 0;
		}
	}
}
