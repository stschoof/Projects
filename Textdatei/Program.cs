using System;
using System.IO;

namespace Textdatei
{
    class Program
    {
        static void Main(string[] args)
        {
            //Benutzereingabe anfordern
            Console.WriteLine("Geben Sie die zu öffnende Datei an: ");
            string dateiName = Console.ReadLine();

            //prüfen, ob die angegebene Datei vorhanden ist
            if (! File.Exists(dateiName))
            {
                Console.WriteLine("Die Datei {0} existiert nicht!", dateiName);
                Console.ReadLine();
                return;
            }

            //Datei öffnen
            FileStream dateiStream = File.Open(dateiName, FileMode.Open);
            //Byte-Array, in das die Daten aus dem Datenstrom lesen
            byte[] puffer = new byte[dateiStream.Length];
            //die Zeichen aus der Datei lesen und in das Array schreiben
            dateiStream.Read(puffer, 0, (int)dateiStream.Length);
            //das Byte-Array elementweise einlesen und jedes Array-Element in Char konvertieren
            for(int i=0;i<dateiStream.Length;i++)
            {
                Console.WriteLine(Convert.ToChar(puffer[i]));
            }
            Console.ReadLine();
        }
    }
}
