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

namespace ZeichenZaehlenWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            eingabe.KeyUp += changed;
        }
        public void changed(object sender, RoutedEventArgs e)
        {
            labelZeichen.Content = "Anzahl der Zeichen" + "\n" + eingabe.Text.Length;
            labelWorte.Content = "Anzahl der Worte" + "\n" + (eingabe.Text.Split(' ', ' ').Length).ToString();
        }
    }
}
