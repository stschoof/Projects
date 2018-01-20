using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace KlassenWpfApplication
{
    class Kunde
    {
        public static int kundenummer;
        public Image wagen = new Image();
        
        public Kunde()
        {
            kundenummer++;
            wagen.Source = new BitmapImage(new Uri("C:\\Users\\Admin\\Desktop\\shopping-cart.png"));
        }
    }
}
