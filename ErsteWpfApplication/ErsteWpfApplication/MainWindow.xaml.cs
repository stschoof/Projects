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

namespace ErsteWpfApplication
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

		private void button_Click(object sender, RoutedEventArgs e)
		{
			textBox.AppendText( DateTime.Now.ToString() + " wurde der Knoppi gedrückt\n ");

		}

		private void radioButton_Checked(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Finger Wech doaahhhh!!!!");
		}

		private void textBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			
		}
	}
}
