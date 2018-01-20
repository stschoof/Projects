using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AutoConsole
{
	internal class Auto
	{
		int id; 
		int baujahr;
		int km;
		int leistung;

		public Auto()
		{

		}

		public Auto(int id, int baujahr, int km, int leistung)
		{
			this.Id = id;
			this.Baujahr = baujahr;
			this.Km = km;
			this.Leistung = leistung;
		}

		public int Id { get => id; set => id = value; }
		public int Baujahr { get => baujahr; set => baujahr = value; }
		public int Km { get => km; set => km = value; }
		public int Leistung { get => leistung; set => leistung = value; }

		public void AutoAnzeigen()
		{
			StreamReader reader = new StreamReader(@"C:\Users\Admin\Desktop\Auto.txt");
			while (reader.Peek() != -1)
			{
				//Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine(reader.ReadLine());
			}
			reader.Close();
		}


		public void AutoSchreiben (Auto auto)
		{
			StreamWriter writer = new StreamWriter(@"C:\Users\Admin\Desktop\Auto.txt",true);
			writer.WriteLine("_____________________");
			writer.WriteLine("ID: " + auto.Id);
			writer.WriteLine("Baujahr: "+ auto.Baujahr);
			writer.WriteLine("KM: "+ auto.km);
			writer.WriteLine("Leistung: "+ auto.Leistung+"\n");
			writer.Close();
		}


	}
}
