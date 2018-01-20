using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace KlasseMitSpielerWpfApplication
{
    class Spieler
    {
        public static int spielernummer = 0;
        public Image dummy = new Image();

        public Spieler()
        {
            spielernummer++;
            dummy.Source = new BitmapImage(new Uri("C:\\Users\\Admin\\Desktop\\Spieler.png"));
        }
    }
}
