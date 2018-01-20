using System;
using System.Globalization;
using static System.Console;
using static System.ConsoleColor;

namespace Formatausdruck_ConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			OutputEncoding = System.Text.Encoding.Unicode;
			int maxWidth = LargestWindowWidth;
			int maxHeight = LargestWindowHeight;
			int topLine = 0;
			string dateString = $"Heute: {DateTime.Now.ToLongDateString()}";
			int lengthDateTimeNow = dateString.Length;
			double gesamt = 0;
			SetWindowSize(maxWidth / 2, maxHeight / 2);
			BackgroundColor = Black;
			Clear();
			SetCursorPosition(maxWidth / 2 - lengthDateTimeNow - 1, topLine);
			ForegroundColor = Red;
			WriteLine(dateString);

			string timeString = $"Jetzt: {DateTime.Now.ToLongTimeString()}";
			int lenghtTimeNow = timeString.Length;
			ForegroundColor = Green;
			SetCursorPosition(maxWidth / 2 - lenghtTimeNow - 1, topLine + 1);
			WriteLine(timeString);
			SetCursorPosition(2, 8);
			WriteLine("Artikel\tEinzelpreis\tMenge\tSumme");
			for (int zeile = 10; zeile < 15; zeile++)
			{
				double ep = zeile - 9 * (0.52);
				SetCursorPosition(2, zeile);
				ForegroundColor = (ConsoleColor)(zeile % 16);
				WriteLine($"Artikel {zeile - 9 }");
				SetCursorPosition(16, zeile);
				ForegroundColor = (ConsoleColor)(zeile % 16);
				WriteLine($"{ep}" + " €");
				SetCursorPosition(32, zeile);
				double menge = Convert.ToDouble(ReadLine());
				SetCursorPosition(40, zeile);
				WriteLine(menge * ep + " €");
				gesamt += (menge * ep);
				SetCursorPosition(CursorLeft + 30, CursorTop += 2);
				ForegroundColor = White;
				WriteLine("Sie haben " + gesamt + " € rausgehauen");
				SetCursorPosition(CursorLeft+30, CursorTop-2);
				WriteLine("                                                ");

			}
						
			/*SetCursorPosition(CursorLeft+30, CursorTop+=2);
			ForegroundColor = White;
			WriteLine("Sie haben " + gesamt + " € rausgehauen");
			ReadLine();*/
			


		ReadLine();
		}

	}
}