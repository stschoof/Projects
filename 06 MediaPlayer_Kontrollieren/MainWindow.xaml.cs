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

namespace MediaPlayer_Kontrollieren
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private MediaTimeline _timeline;
    private MediaClock _clock;

    void Window_Loaded(object sender, RoutedEventArgs e)
    {
      _timeline = new MediaTimeline();
      _timeline.Source = new Uri("Gitarrensound.wav",
                                  UriKind.Relative);

      _clock = _timeline.CreateClock();
      _clock.CurrentTimeInvalidated += OnCurrentTimeInvalidated;
      _clock.Controller.Stop();

      MediaPlayer player = new MediaPlayer();
      player.MediaOpened += OnPlayerMediaOpened;
      player.Clock = _clock;
    }

    void OnPlayerMediaOpened(object sender, EventArgs e)
    {
      MediaPlayer player = sender as MediaPlayer;
      progressBar.Maximum = player.NaturalDuration.TimeSpan.Ticks;
      progressBar.Minimum = 0;
    }

    void OnCurrentTimeInvalidated(object sender, EventArgs e)
    {
      txtTime.Text = _clock.CurrentTime.ToString();
      progressBar.Value = _clock.CurrentTime.Value.Ticks;
    }

    void PlayButton_Click(object sender, RoutedEventArgs e)
    {
      _clock.Controller.Begin();
    }
  }
}
