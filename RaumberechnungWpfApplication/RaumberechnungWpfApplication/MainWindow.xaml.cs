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

namespace RaumberechnungWpfApplication
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

        private void btnRaum_MouseMove(object sender, MouseEventArgs e)
        {
            btnRaum.Content = sliderBreite.Value * sliderHoehe.Value + " qm aus:\n" + sliderBreite.Value + " m und " + sliderHoehe.Value +" m";
        }

        
    }
}
