using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateiBeispiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Program verzeichnisTest = new Program();
            FileInfo meineDatei;

            //Benutzereingabe
            string pfad = verzeichnisTest.PfadEingabe();
            int laenge = pfad.Length;

            //alle Dateien und Ordner holen
            if (Directory.Exists(pfad))
            {
                string[] inhalt = Directory.GetFileSystemEntries(pfad);
                Console.WriteLine();
                Console.WriteLine("Ordner und Dateien im Verzeichnis {0}", pfad);
                Console.WriteLine(new string('-', 80));
                for (int i = 0; i <= inhalt.GetUpperBound(0);i++)
                {
                    //prüfen, ob der Eintrag ein Verzeichnis oder eine Datei ist
                    if (0 == (File.GetAttributes(inhalt[i]) & FileAttributes.Directory))
                    {
                        meineDatei = new FileInfo(inhalt[i]);
                        string dateiAttribut = verzeichnisTest.holeDateiAttribute(meineDatei);
                        Console.WriteLine("{0,-30}{1,25} kB {2,-10}", inhalt[i].Substring(laenge - 1), meineDatei.Length / 1024, dateiAttribut);
                    }
                    else
                    {
                        Console.WriteLine("{0,-30}{1,-15}", inhalt[i].Substring(laenge), "Dateiorder");
                    }
                }
                Console.ReadLine();
            }
        }

        //Benutzer zur Eingabe des Pfades auffordern
        string PfadEingabe()
        {
            Console.Write("Geben Sie den zu durchsuchenden ");
            Console.Write("Ordner an: ");
            string suchMuster = Console.ReadLine();

            //Wenn die Benutzereingabe als letztes Zeichen kein '\'
            //enthält, muss dieses angehängt werden
            if(suchMuster.Substring(suchMuster.Length-1)!="\\")
             {
                suchMuster += "\\";
             }
            return suchMuster;
        }

        //Feststellung, welche Dateiattribute gesetzt sind und
        //Rückgabe eines Strings, der die gesetzten Attribute enthält
        string holeDateiAttribute(FileInfo file)
        {
            string attribute;

            //prüfen, ob das Archive-Attribut gesetzt ist
            if (0 != (file.Attributes & FileAttributes.Archive))
            {
                attribute = "A";
            }
            else
            {
                attribute = " ";
            }
            //prüfen, ob das Hidden-Attribut gesetzt ist
            if (0 != (file.Attributes & FileAttributes.Hidden))
            {
                attribute += "H";
            }
            else
            {
                attribute += " ";
            }

            //prüfen, ob das ReadOnly-Attribut gesetzt ist
            if (0 != (file.Attributes & FileAttributes.ReadOnly))
            {
                attribute += "R";
            }
            else
            {
                attribute += " ";
            }

            //prüfen, ob das System-Attribut gesetzt ist
            if (0 != (file.Attributes & FileAttributes.System))
            {
                attribute += "S";
            }
            else
            {
                attribute += " ";
            }

            return attribute;
        }
    }
}
