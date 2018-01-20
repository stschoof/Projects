using System;
using static System.Console;
using static System.ConsoleColor;

namespace classConsole_ConsoleApplication
{
	class Program
	{

		static void Main(string[] args)
		{
			BackgroundColor = Red;
			Clear();
			ForegroundColor = White;
			SetCursorPosition(48, 0);
			WriteLine("Titel");
			ForegroundColor = Yellow;
			SetCursorPosition(0, 3);
			WriteLine("Navigation");
			for (int k = 1; k < 4; k++)
			{
				WriteLine("Ziel" + k);
			}

			SetCursorPosition(25, 5);
			ForegroundColor = Blue;

			for (int i = 6; i < 16; i++)
			{
				WriteLine("Lorem Ipsum ..........", WindowWidth);
				SetCursorPosition(25, i);
			}

			SetCursorPosition(0, 23);
			ForegroundColor = White;
			WriteLine("Impressum");
			ReadLine();

		}
	}
}
