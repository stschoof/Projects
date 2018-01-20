using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pfad
{
    class Program
    {
        static void Main(string[] args)
        {
            string pfad = @"C:\Windows\system32\kernel32.dll";

            //liefert C:\
            Console.WriteLine(Path.GetPathRoot(pfad));

            //liefert C:\Windows\system32
            Console.WriteLine(Path.GetDirectoryName(pfad));

            //liefert kernel32
            Console.WriteLine(Path.GetFileNameWithoutExtension(pfad));

            // liefert kernel32.dll

            Console.WriteLine(Path.GetFileName(pfad));

            // liefert C:\windows\system32\kernel32.dll

            Console.WriteLine(Path.GetFullPath(pfad));

            // liefert .dll

            Console.WriteLine(Path.GetExtension(pfad));

            //liefert uns den Pfad zum Temp-Ordner zurück
            Console.WriteLine(Path.GetTempPath());

            //erzeugt eine leere Datei im Temp-Ordner und liefert den kompletten Pfad zurück
            string tempDatei = Path.GetTempFileName();
            Console.WriteLine(tempDatei);
            File.Delete(tempDatei);

            if(File.Exists(tempDatei))
            {
                Console.WriteLine("Datei nicht gelöscht");
            }
            else
            {
                Console.WriteLine("Temp-Datei erfolgreich gelöscht");
            }

            DriveInfo laufwerk = new DriveInfo("c");
            Console.WriteLine(laufwerk.AvailableFreeSpace);
            Console.WriteLine(laufwerk.DriveFormat);
            Console.WriteLine(laufwerk.DriveType);
            Console.WriteLine(laufwerk.IsReady);
            Console.WriteLine(laufwerk.Name);
            Console.WriteLine(laufwerk.RootDirectory);
            Console.WriteLine(laufwerk.TotalFreeSpace);
            Console.WriteLine(laufwerk.TotalSize);
            Console.WriteLine(laufwerk.VolumeLabel);

            Console.ReadLine();
        }
    }
}
