using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Punkte
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point-Array erzeugen
            Point[] pArr = new Point[2];
            Point p = new Point();
            p.XPos = 10;
            p.YPos = 20;
            p.color = 310;
            pArr[0] = p;
            p = new Point();
            p.XPos = 40;
            p.YPos = 50;
            p.color = 110;
            pArr[1] = p;
            //pArr[0].XPos = 10;
            //pArr[0].YPos = 20;
            //pArr[0].color = 310;
            //pArr[1].XPos = 40;
            //pArr[1].YPos = 50;
            //pArr[1].color = 110;

            //Point-Array speichern
            SchreibInDatei(@"e:\unterricht\punkte.dat", pArr);
            //gespeicherte Informationen aus der Datei einlesen
            Point[] neuesArr = HolePunkte(@"e:\unterricht\punkte.dat");
            //alle Point's ausgeben
            for(int i=0;i<neuesArr.Length;i++)
            {
                Console.WriteLine("Point-Objekt-Nr. {0}", i + 1);
                Console.WriteLine();
                Console.WriteLine("neuesArr[{0}].XPos = {1}", i, neuesArr[i].XPos);
                Console.WriteLine("neuesArr[{0}].YPos = {1}", i, neuesArr[i].YPos);
                Console.WriteLine("neuesArr[{0}].Color = {1}", i, neuesArr[i].color);
                Console.WriteLine(new string('=', 30));
            }

            //einen bestimmten Point einlesen
            Console.WriteLine("\nWelchen Punkt möchten Sie einlesen?");
            int position = Convert.ToInt32(Console.ReadLine());
            try
            {
                Point meinPoint = HolePunkt(@"e:\unterricht\punkte.dat", position);
                Console.WriteLine("meinPoint.XPos = {0}", meinPoint.XPos);
                Console.WriteLine("meinPoint.YPos = {0}", meinPoint.YPos);
                Console.WriteLine("meinPoint.Color = {0}", meinPoint.color);
            }
            catch(PositionException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        private static Point HolePunkt(string pfad, int punktNr)
        {
            FileStream fs = new FileStream(pfad, FileMode.Open);
            int pos = 4 + (punktNr - 1) * 16;
            BinaryReader binLeser = new BinaryReader(fs);
            if (punktNr > binLeser.ReadInt32() || punktNr == 0)
            {
                string nachricht = "Unter der angegebenen Position ist";
                nachricht += "kein \nPoint-Objekt gespeichert";
                throw new PositionException(nachricht);
            }
            //den Zeiger positionieren
            fs.Seek(pos, SeekOrigin.Begin);
            Point punkt = new Point();
            punkt.XPos = binLeser.ReadInt32();
            punkt.YPos = binLeser.ReadInt32();
            punkt.color = binLeser.ReadInt64();
            binLeser.Close();
            return punkt;
        }

        public static void SchreibInDatei(string path, Point[] array)
        {
            FileStream datenStream = new FileStream(path, FileMode.Create);
            BinaryWriter binSchreiber = new BinaryWriter(datenStream);

            //Anzahl der Punkte in die Datei schreiben
            binSchreiber.Write(array.Length);

            //die Point-Daten in die Datei schreiben
            for(int i=0; i< array.Length;i++)
            {
                binSchreiber.Write(array[i].XPos);
                binSchreiber.Write(array[i].YPos);
                binSchreiber.Write(array[i].color);
            }
            binSchreiber.Close();
        }

        public static Point[] HolePunkte(string pfad)
        {
            FileStream fs = new FileStream(pfad, FileMode.Open);
            BinaryReader binLeser = new BinaryReader(fs);

            //liest die ersten 4 Bytes aus der Datei, die die Anzahl der Point-Objekte enthält
            int anzahl = binLeser.ReadInt32();

            //Lesen der Daten aus der Datei
            Point[] arrPoint = new Point[anzahl];
            Point p = new Point();
            for (int i=0;i<anzahl;i++)
            {
                p = new Point();
                p.XPos= binLeser.ReadInt32();
                p.YPos= binLeser.ReadInt32();
                p.color= binLeser.ReadInt64();
                arrPoint[i] = p;
                //arrPoint[i].XPos = binLeser.ReadInt32();
                //arrPoint[i].YPos = binLeser.ReadInt32();
                //arrPoint[i].color = binLeser.ReadInt64();
            }
            binLeser.Close();
            return arrPoint;
        }
    }

    public class PositionException : Exception
    {
        public PositionException() { }
        public PositionException(string message) : base(message) { }
        public PositionException(string message, Exception inner) : base(message, inner) { }
    }

    class Point
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public long color { get; set; }
    }
}
