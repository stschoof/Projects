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

namespace MediaPlayer_Video
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      var player = new MediaPlayer();
      player.Open(new Uri("thomasOnBoard.wmv", UriKind.Relative));      

      var drawing = new VideoDrawing();
      drawing.Player = player;
      drawing.Rect = new Rect(0, 0, 290, 200);

      var brush = new DrawingBrush(drawing);
      rect.Fill = brush;

      player.Play();
    }
  }
}
