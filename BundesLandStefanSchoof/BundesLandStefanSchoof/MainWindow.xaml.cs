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

namespace BundesLandStefanSchoof
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
               

        private void btnTabA_Click(object sender, RoutedEventArgs e)
        {
            foreach (RadioButton item in GridA.Children)
            {
                if (item.IsChecked == true)
                {
                    MessageBox.Show(item.Content.ToString());
                    
                }
            }

           
            //Grid GridA = tabControl.SelectedContent as Grid;
            //MessageBox.Show(GridA.Children[0].ToString());
        }
    }
}
