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

namespace JukeBoxWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //MediaPlayer mediaPlayer = new MediaPlayer();
        public Uri pfad = new Uri("C:\\Users\\Master\\Documents\\Visual Studio 2013\\Projects\\JukeBoxWpfApplication\\JukeBoxWpfApplication\\");
        public string datei;
        public string abspielen;
        MediaClock _clock;
       
        public MainWindow()

        {
            InitializeComponent();

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var wahl = sender as RadioButton;
            string datei = wahl.Tag.ToString();
            abspielen = pfad + datei;
        }

        private void btnAbspielen_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();
            MediaTimeline tl = new MediaTimeline();
            tl.Source =new Uri(abspielen);
            _clock=tl.CreateClock();
            mediaPlayer.Clock = _clock;
            _clock.Controller.Begin();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            _clock.Controller.Stop();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            _clock.Controller.Pause();
        }

        private void btnResume_Click(object sender, RoutedEventArgs e)
        {
            _clock.Controller.Resume();
        }
    }
}
