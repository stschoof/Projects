using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinärDatei
{
    class Program
    {
        static void Main(string[] args)
        {
            //eine Datei erzeugen und einen Integer-Wert in die Datei schreiben

            FileStream stream = new FileStream(@"e:\unterricht\bindatei.dat", FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);
            int zahl = 500;
            writer.Write(zahl);
            writer.Close();

            //Datei öffnen und den Inhalt byteweise auslesen
            FileInfo fi = new FileInfo(@"e:\unterricht\bindatei.dat");
            FileStream fs = new FileStream(@"e:\unterricht\bindatei.dat", FileMode.Open);
            byte[] byteArr = new byte[fi.Length];
            //Datenstrom in ein Byte-Array einlesen
            fs.Read(byteArr, 0, (int)fi.Length);

            //Konsolenausgabe
            Console.WriteLine("Interpretation als Byte-Array: ");
            for(int i=0; i<fi.Length;i++)
            {
                Console.WriteLine(byteArr[i]);
            }
            Console.Write("\n\n");
            fs.Close();

            StreamReader sReader = new StreamReader(@"e:\unterricht\bindatei.dat");
            Console.WriteLine("Interpretation als Text");
            Console.WriteLine(sReader.ReadToEnd());
            sReader.Close();

            fs = new FileStream(@"e:\unterricht\bindatei.dat", FileMode.Open);
            BinaryReader bReader = new BinaryReader(fs);
            Console.WriteLine(bReader.ReadInt32());
            Console.ReadLine();

        }
    }
}
