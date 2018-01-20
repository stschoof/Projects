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
using System.IO;
using System.Diagnostics;
using System.Windows.Threading;

namespace SnapShots
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    GifBitmapEncoder _encoder;
    DispatcherTimer _timer;

    private void MediaElement_MediaOpened(object sender, RoutedEventArgs e)
    {
      _timer = new DispatcherTimer();
      _timer.Interval = TimeSpan.FromMilliseconds(100);
      _timer.Tick += OnTick;
      _timer.Start();
    }
    void OnTick(object sender, EventArgs e)
    {
      Size dpi = new Size(96, 96);
      RenderTargetBitmap bmp =
        new RenderTargetBitmap(300, 200,
          dpi.Width, dpi.Height, PixelFormats.Pbgra32);
      bmp.Render(media);

      if (_encoder == null)
        _encoder = new GifBitmapEncoder();
      _encoder.Frames.Add(BitmapFrame.Create(bmp));
    }
    private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
    {
      _timer.Tick -= OnTick;
      _timer = null;


      string filename = Guid.NewGuid().ToString() + ".gif";
      FileStream fs = new FileStream(filename, FileMode.Create);
      _encoder.Save(fs);
      fs.Close();
      _encoder = null;

      Process.Start("iexplore.exe",new FileInfo(filename).FullName);
    }
  }
}
