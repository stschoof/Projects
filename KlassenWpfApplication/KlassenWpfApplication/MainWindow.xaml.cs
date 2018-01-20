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

namespace KlassenWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int anzKunden;
        int positon = 0;
        public MainWindow()
        {
            InitializeComponent();
            Kunde.kundenummer = 1;
            // hier geht es schon, aber dann
            // ist noch kein fertiges fenster gezeichnet
            // Kunde meier = new Kunde();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*Kunde meier = new Kunde();
            raumdarstellung.Children.Add(new Image() { Source = meier.wagen.Source, Height = 40, Width = 40 });
            Canvas.SetLeft(raumdarstellung.Children[raumdarstellung.Children.Count - 1], 30);

            Kunde schulz = new Kunde();
            raumdarstellung.Children.Add(new Image() { Source = meier.wagen.Source, Height = 40, Width = 40 });
            Canvas.SetLeft(raumdarstellung.Children[raumdarstellung.Children.Count - 1], 60
                );
            Kunde schmidt = new Kunde();
            raumdarstellung.Children.Add(new Image() { Source = meier.wagen.Source, Height = 40, Width = 40 });
            Canvas.SetLeft(raumdarstellung.Children[raumdarstellung.Children.Count - 1], 90);*/
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            anzKunden = Convert.ToInt32(anzahl.Text);
            for(int i = 0; i < anzKunden; i++)
            {
                positon += 40;
                Kunde n = new Kunde();
                raumdarstellung.Children.Add(n.wagen);
                n.wagen.Height = 40;
                n.wagen.Width = 40;
                Canvas.SetTop(raumdarstellung.Children[raumdarstellung.Children.Count - 1], positon);

                DoubleAnimation x = new DoubleAnimation();
				
               
				//x.BeginTime = TimeSpan.Parse("0:0:" + Kunde.kundenummer);

				for (int k = 1; k < 360; k++)
				{
					x.From = 0+k;
					x.To = +k;
					x.Duration = TimeSpan.Parse("0:0:4");
					n.wagen.BeginAnimation(Canvas.LeftProperty, x);
					n.wagen.BeginAnimation(Canvas.TopProperty, x);
				}
				
			}
        }
    }
}
