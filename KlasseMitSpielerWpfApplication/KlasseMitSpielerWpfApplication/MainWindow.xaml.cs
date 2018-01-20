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

namespace KlasseMitSpielerWpfApplication
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

            int position = 0;
            int position2 = 0;
            int position3 = 80;
            int top = 0;
            for (int i = 0; i < 11; i++)
            {
                StackPanel spieler = new StackPanel();
                spieler.Name = "s" + i;
                Spieler n = new Spieler();
                Label nummer = new Label();
                n.dummy.Height = 40;
                n.dummy.Width = 40;
                spieler.Children.Add(n.dummy);
                spieler.Children.Add(nummer);
                nummer.Content = Spieler.spielernummer;
                if (i == 0)
                {
					top = 0;
                    spielfeld.Children.Add(spieler);
                    Canvas.SetLeft(spielfeld.Children[spielfeld.Children.Count - 1], 200);
					Canvas.SetTop(spielfeld.Children[spielfeld.Children.Count - 1], top);
				}
                else if(i <= 4)
                {
                    top = 100;
                    position += 80;
                    spielfeld.Children.Add(spieler);
                    Canvas.SetLeft(spielfeld.Children[spielfeld.Children.Count - 1], position);
                    Canvas.SetTop(spielfeld.Children[spielfeld.Children.Count - 1], top);
                }
                else if (i >= 5 && i <= 8)
                {
                    top = 200;
                    position2 += 80;
                    spielfeld.Children.Add(spieler);
                    Canvas.SetLeft(spielfeld.Children[spielfeld.Children.Count - 1], position2);
                    Canvas.SetTop(spielfeld.Children[spielfeld.Children.Count - 1], top);
                }
                else if(i >= 9)
                {
                    
                    top = 300;
                    position3 += 80;
                    spielfeld.Children.Add(spieler);
                    Canvas.SetLeft(spielfeld.Children[spielfeld.Children.Count - 1], position3);
                    Canvas.SetTop(spielfeld.Children[spielfeld.Children.Count - 1], top);
                }

            }
        }

		private void b1_Click(object sender, RoutedEventArgs e)
		{
			
				int spielerNr;
				spielerNr = Convert.ToInt32(spnr.Text);
				DoubleAnimation x = new DoubleAnimation();
				x.To = 300;
				x.Duration = TimeSpan.Parse("0:0:2");
				x.AutoReverse = true;
				DoubleAnimation y = new DoubleAnimation();
				y.To = 460;
				y.Duration = TimeSpan.Parse("0:0:2");
				y.AutoReverse = true;
				spielfeld.Children[spielerNr + 1].BeginAnimation(Canvas.LeftProperty, x);
				spielfeld.Children[spielerNr + 1].BeginAnimation(Canvas.TopProperty, y);

			
		}
	}
}
