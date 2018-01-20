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

namespace Bsp_01_RadioButton_StEl
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool Windows7 { get; set; }
        public bool Windows8 { get; set; }
        public bool Windows10 { get; set; }
        public bool Office2010 { get; set; }
        public bool Office2013 { get; set; }
        public bool Office2016 { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Windows10: " + Windows10 + "\n"
                + "Microsoft Office 2016: " + Office2016);
        }
    }
}
