﻿using System;
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

namespace SpielerWpfApp
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

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			for (int i = 0; i <= 10; i++)
			{
				Label labeltemp = new Label();
				labeltemp.Name = "labspieler" + i;
				//MessageBox.Show(labeltemp.Name);
				labeltemp.Content = Spieler.spielernummer;

				//griddi.Children.Add(labeltemp);
				//labspieler0.Content = Spieler.spielernummer;		
				Spieler.spielernummer++;

			}
			//labspieler1.Content = Spieler.spielernummer;
		}
	}
}
