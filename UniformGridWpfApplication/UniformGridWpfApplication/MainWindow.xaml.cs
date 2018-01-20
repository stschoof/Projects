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

namespace UniformGridWpfApplication
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

		private void up_Click(object sender, RoutedEventArgs e)
		{
			ausgabe.AppendText(" up ");
		}

		private void left_Click(object sender, RoutedEventArgs e)
		{
			ausgabe.AppendText(" left ");
		}

		private void right_Click(object sender, RoutedEventArgs e)
		{
			ausgabe.AppendText(" right ");
		}

		private void down_Click(object sender, RoutedEventArgs e)
		{
			ausgabe.AppendText(" down ");
		}
	}
}
