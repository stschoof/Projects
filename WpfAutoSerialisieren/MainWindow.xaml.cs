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

namespace WpfAutoSerialisieren
{
	/// <summary>
	/// Interaktionslogik für MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private static List<Auto> autoliste = new List<Auto>();

		public MainWindow()
		{
			InitializeComponent();
            
            
			
			
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			Auto a = new Auto();
			a.Id = Convert.ToInt32(tbID.Text);
			a.Baujahr = Convert.ToInt32(tbBJ.Text);
			a.Km = Convert.ToInt32(tbKM.Text);
			a.Leistung = Convert.ToInt32(tbLeist.Text);
			autoliste.Add(a);
			rtbAnzeige.AppendText("ID " +  a.Id.ToString() + " BJ " + a.Baujahr.ToString() + " KM " + a.Km.ToString()  +" PS " + a.Leistung.ToString() + "\n");
		 	
		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			Datei.Serialisieren(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\AutoSerial.dat", autoliste);
			
		}

		private void btnLaden_Click(object sender, RoutedEventArgs e)
		{
			
			List<Auto> neueListe = new List<Auto>();
			neueListe = (List<Auto>)Datei.Deserialisieren(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\AutoSerial.dat");
			rtbAnzeige.Document.Blocks.Clear();
			for (int i = 0; i < neueListe.Count; i++)
			{

				rtbAnzeige.AppendText("ID "+ neueListe[i].Id + " BJ " +neueListe[i].Baujahr + " KM "
					+ neueListe[i].Km + " PS " + neueListe[i].Leistung + "\n");

			}


		}

		private void btnLöschen_Click(object sender, RoutedEventArgs e)
		{
			rtbAnzeige.Document.Blocks.Clear();
		}

        private void WindowLoad(object sender, RoutedEventArgs e)
        {
           
            List<Auto> neueListe = new List<Auto>();
            neueListe = (List<Auto>)Datei.Deserialisieren(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\AutoSerial.dat");

            for (int i = 0; i < neueListe.Count; i++)
            {
                rtbAnzeige.AppendText("ID " + neueListe[i].Id + " BJ " + neueListe[i].Baujahr + " KM "
                    + neueListe[i].Km + " PS " + neueListe[i].Leistung + "\n");

            }
        }
    }
}
