using System;
using System.Globalization;
using static System.Console;
using static System.ConsoleColor;

namespace WarenKorbArray
{
	class Program
	{
		static void Main(string[] args)
		{

			string[,] artikel = new string[5, 2]
			{ { "Mettigel        ", "   1.95" },
			{ "Phosphatschlauch  ", "   2.54" },
			{ "Altölstäbchen     ", "   3.93" },
			{ "Halber Hahn       ", "   4.42" },
			{ "2 Halbe Hahn      ", "   5.91" } };

	
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			int maxWidth = LargestWindowWidth;
			int maxHeight = LargestWindowHeight;
			int topLine = 0;
			int secondLine = 1;
			string dateString = $"Heute: {DateTime.Now.ToLongDateString()}";
			string timeString = $"{DateTime.Now.ToShortTimeString()}";
			int lengthDateTimeNow = dateString.Length;
			int lengthTimeStringNow = timeString.Length;
			SetWindowSize(maxWidth / 2, maxHeight / 2);
			BackgroundColor = Black;
			Clear();
			SetCursorPosition(maxWidth / 2 - lengthDateTimeNow - 1, topLine);
			ForegroundColor = Red;
			WriteLine(dateString);
			SetCursorPosition(maxWidth / 2 - lengthTimeStringNow - 1, secondLine);
			ForegroundColor = Green;
			WriteLine(timeString);
			SetCursorPosition(maxWidth / 2 - lengthDateTimeNow - 1, secondLine);
			WriteLine("Jetzt:");
			ForegroundColor = White;
			SetCursorPosition(2, 8);
			WriteLine("Bezeichnung:\t\t Einzelpreis:\t Anzahl:\t Zwischensumme:\t Gesamtbetrag:");

			for (int index1 = 0; index1 < artikel.GetLength(0); index1++) // Länge des Array´s
			{
				SetCursorPosition(2, 10 + index1);
				ForegroundColor = ConsoleColor.Green;


				for (int i = 0; i < artikel.GetLength(1); i++)
				{

					Write(artikel[index1, i] + "\t");
				}

			}
			Write("X");

			// variablo "woBinIch" >>>> Wert des Artikels zuweisen eg 1.95 * menge = Preis und unten gesamt
			// 1 Zeile Weert= 1,95 +
			// 2. Zeile Wert xxxxx
			

			int zeile = 10;
			int spalte = 43;

			
				
			
			SetCursorPosition(spalte, zeile);
			ConsoleKeyInfo cki;
			
			do
			{

				cki = Console.ReadKey();

				if (zeile >= 10 && zeile < 14) // true wenn im erlaubten Bereich
				{
					
					switch (cki.Key.ToString())

					{
						case "UpArrow": SetCursorPosition(spalte, --zeile); break;
						case "DownArrow": SetCursorPosition(spalte, ++zeile); break;
						//case "Enter": WriteLine(cki.Key.ToString()); break;
						case "D0":Write("1");break;
						case "D1":Write("2"); break;
						case "D2":; break;
						case "D3":; break;
						case "D4":; break;
						case "D5":; break;
						case "D6":; break;
						case "D7":; break;
						case "D8":; break;
						case "D9":; break;
						case "Enter":; break;


						default: ; break;

					}
					//Write(spalte);
					//Console.WriteLine(zeile + "," + spalte);
				} else
				{

					SetCursorPosition(43,10);
					zeile = 10;
					spalte = 43;

					//WriteLine("Nicht so weit ....");

				}

					//Console.WriteLine(cki.Key.ToString());
				} while (cki.Key != ConsoleKey.Escape) ;

			
			ReadLine();
		}
	}
}


