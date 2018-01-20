using System;
using static System.Console;

namespace zahlentausch_181
{

	class Program
	{

		static void Main()
		{
			int[] input = new int[2];

			do
			{
				bool[] bo_input_ok = new bool[] { false, false };

				while (!bo_input_ok[0])
				{
					"Bitte zahl_1 eingeben: ".Message();
					bo_input_ok[0] = int.TryParse(ReadLine(), out input[0]);
				}
				while (!bo_input_ok[1])
				{
					"Bitte zahl_2 eingeben: ".Message();
					bo_input_ok[1] = int.TryParse(ReadLine(), out input[1]);
				}

				input = input.tausche();

				("zahl_1: " + input[0].ToString() + Environment.NewLine + "zahl_2: " + input[1].ToString()).MessageLine();

			} while (!("again? exit ESC".EndMessage().Key == ConsoleKey.Escape));
		}
	}

	public static class MyExtensions
	{

		public static void Message(this string s) => Write(s);

		public static void MessageLine(this string s) => WriteLine(s);

		public static ConsoleKeyInfo EndMessage(this string s)
		{ s.MessageLine(); return ReadKey(true); }

		public static int[] tausche(this int[] input)
		{
			int[] result = new int[2];
			input.CopyTo(result, 0);
			result[0] += result[1];
			result[1] = result[0] - result[1];
			result[0] -= result[1];
			return result;
		}
	}
}