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

namespace SchachFeldAnlegenWpfApplication
{
	/// <summary>
	/// Interaktionslogik für MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			for (int i =0; i < 64; i++)
			{
				
				Button knopp = new Button();
				knopp.Name = "knopp" + i;
				knopp.Content = "\u265A"; // Black King
				knopp.FontSize = 48;
				schachbrett.Children.Add(knopp);
				knopp.Click += zeigen;
				knopp.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
				

				if ((i + (int) i/8)  % 2  == 0)
				{
					knopp.Content = "\u2654"; // White King
					knopp.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
					knopp.Foreground = new SolidColorBrush(Color.FromRgb(255,255,255));
				}
			}


		}

		public void zeigen(object sender, RoutedEventArgs e)
		{

			//MessageBox.Show(((Button)sender).Content.ToString());
			Fenster.Title=(((Button)sender).Content.ToString());
		}

	}
	
}
