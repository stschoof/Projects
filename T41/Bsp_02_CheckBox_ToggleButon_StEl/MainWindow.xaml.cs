using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bsp_02_CheckBox_ToggleButon_StEl
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

        private void einaus_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton tb = sender as ToggleButton;
            tb.Content = tb.IsChecked;
        }

        private void null_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton tb = sender as ToggleButton;
            if (tb.IsChecked == null)
                tb.Content = "x:Null";
            else
                tb.Content = tb.IsChecked;

            if (tb.IsChecked == true)
                sp.Background = new SolidColorBrush(Colors.Lime);
            else if (tb.IsChecked == false)
                sp.Background = new SolidColorBrush(Colors.Red);
            else
                sp.Background = new SolidColorBrush(Colors.Yellow);
        }
    }
}
