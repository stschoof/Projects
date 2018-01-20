using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoConsole
{
	class Program
	{


		static void Main(string[] args)
		{
			do
			{
				
				Console.WriteLine("Bitte geben Sie ein Auto ein (ID,BAUJAHR,KM,LEISTUNG)");
				
				//Auto[] karrenArray = new Auto[3];
                List<Auto> karrenArray = new List<Auto>();

				Auto a = new Auto();
				a.Id= Convert.ToInt32(Console.ReadLine());
				a.Baujahr = Convert.ToInt32(Console.ReadLine());
				a.Km = Convert.ToInt32(Console.ReadLine());
				a.Leistung = Convert.ToInt32(Console.ReadLine());
                karrenArray.Add(a);
                						

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("* * * * S T A R T  * * * ");


				for (int i = 0; i < karrenArray.Count; i++)
				{
					a.AutoSchreiben(karrenArray[i]);
					a.AutoAnzeigen();
				}

				Console.WriteLine("* * * * E N D E * * * *");
				//Console.ReadLine();
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}
