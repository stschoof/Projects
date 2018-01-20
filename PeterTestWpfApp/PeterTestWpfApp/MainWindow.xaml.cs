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

namespace PeterTestWpfApp
{
	/// <summary>
	/// Interaktionslogik für MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void knopp_Click(object sender, RoutedEventArgs e)
		{
			ausgabe.Text= "Knopp wurde gedrückt";
		}

		private void butLoesch_Click(object sender, RoutedEventArgs e)
		{
			ausgabe.Text = " ";
		}
	}
}
