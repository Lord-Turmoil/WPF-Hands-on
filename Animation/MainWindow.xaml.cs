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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animation
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void OnWidthButtonClicked(object sender, RoutedEventArgs e)
		{
			// Prevent double click.
			widthButton.Click -= OnWidthButtonClicked;

			// Create a animation with double value.
			DoubleAnimation anim = new DoubleAnimation();
			// anim.From = widthButton.Width;
			// anim.To = widthButton.Width + 30;
			anim.By = 400;
			anim.Duration = TimeSpan.FromMilliseconds(2000);
			anim.AutoReverse = true;
			anim.AccelerationRatio = 0.8;
			anim.Completed += OnWidthButtonAnimCompleted;

			widthButton.BeginAnimation(Button.WidthProperty, anim);
		}

		private void OnWidthButtonAnimCompleted(object? sender, EventArgs e)
		{
			widthButton.Click += OnWidthButtonClicked;
		}

		private void OnQuitButtonClicked(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
