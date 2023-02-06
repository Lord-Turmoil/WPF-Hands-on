 using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace DataTemplate
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			List<Color> list = new List<Color>
			{
				new Color() { Code = "#AA0000", Name = "Red" },
				new Color() { Code = "#00AA00", Name = "Green" },
				new Color() { Code = "#0000AA", Name = "Blue" }
			};

			advanced.ItemsSource = list;

			/*
			 * Notice that DataGrid will modify ItemSource!!!
			 * So, ListBox mustn't share list with DataGrid.
			 */
			List<Color> gridList = new List<Color>(list);
			grid.ItemsSource = gridList;
		}
	}

	public class Color
	{
		public string? Code { get; set; }

		public string? Name { get; set; }
	}
}
