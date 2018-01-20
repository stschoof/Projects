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

namespace FarbReglerStefanSchoof
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


        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (r != null && g != null && b != null)
            {
                Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r.Value), Convert.ToByte(g.Value), Convert.ToByte(b.Value)));
                labelR.Content = r.Value;
                labelG.Content = g.Value;
                labelB.Content = b.Value;

            }
        }

    }
}
