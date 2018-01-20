using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;
using System.Windows.Resources;

namespace SoundInCSharp
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void ButtonRelative_Click(object sender, RoutedEventArgs e)
    {
      // GAkkord.wav hat die Build Action "Content" und wurde
      // ins Output-Verzeichnis kopiert
      var player = new SoundPlayer("GAkkord.wav");
      player.Play();
    }
    private void ButtonResource_Click(object sender, RoutedEventArgs e)
    {
      // Gitarrensound.wav hat die Build Action "Resource" und wurde somit
      // mit in die Assembly eingebettet. Mit der Application-Klasse
      // lässt sich die Ressource auslesen.
      StreamResourceInfo sri = Application.GetResourceStream(new Uri("Gitarrensound.wav",UriKind.Relative));
      SoundPlayer player = new SoundPlayer(sri.Stream);
      player.Play();
    }
  }
}
