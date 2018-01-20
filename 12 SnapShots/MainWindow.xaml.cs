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

namespace SnapShots
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    void Button_Click(object sender, RoutedEventArgs e)
    {
      Size dpi = new Size(96,96);
      RenderTargetBitmap bmp = 
        new RenderTargetBitmap(300, 200, 
          dpi.Width, dpi.Height, PixelFormats.Pbgra32);
      bmp.Render(media);

      JpegBitmapEncoder encoder = new JpegBitmapEncoder();
      encoder.Frames.Add(BitmapFrame.Create(bmp));

      string filename = Guid.NewGuid().ToString()+".jpg";
      FileStream fs = new FileStream(filename,FileMode.Create);
      encoder.Save(fs);
      fs.Close();

      Process.Start(filename);
    }
  }
}
