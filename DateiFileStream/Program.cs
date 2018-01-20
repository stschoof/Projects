using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateiFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //public FileStream(string pfad, FileMode mode);
            FileStream fs = new FileStream(@"E:\Unterricht\datei.dat", FileMode.OpenOrCreate);
            byte[] array = { (byte)'D', (byte)'a' , (byte)'s' };
            //Schreiben des Arrayinhaltes in die Datei
            fs.Write(array, 0, array.Length);
            //fs.Close();
            //Positionszeiger an den Anfang setzen
            fs.Position = 0;
            byte[] arrayRead = new byte[10];
            //lesen der Byteblöcke aus dem Stream
            fs.Read(arrayRead, 0, 10);
            //Ausgabe des Arrayinhaltes
            for(int i=0;i<arrayRead.Length;i++)
            {
                Console.WriteLine(arrayRead[i]);
            }

            fs.Close();
            Console.ReadLine();
        }
    }
}
