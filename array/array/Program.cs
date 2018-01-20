using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace array
{
	class Program
	{
		static void Main(string[] args)
		{
			// type der im array enthltenen elemente,
			//name des array
			// object anlegen
			// reveriert 5 Plätze im Speicher

			string[] warenkorb = new string[5];
			warenkorb[0] = "200 gr. Tüte Gummibären";
			warenkorb[1] = "1 Pfund Butter"; // immer doppelte Anführungszeichen benutzen für String
			warenkorb[2] = "1 Paprika";

			//WriteLine("Wir wollen kaufen : {0}\n{2}\n{1}", warenkorb);

			for (int i = 0; i < warenkorb.Length; i++)
			{
				//WriteLine(warenkorb[i]);
			}



			object[] universal = new object[5];
			universal[0] = "200 gr. Tüte Gummibären";
			universal[1] = 555;
			universal[2] = 'a';

			for (int i = 0; i < universal.Length; i++)
			{
				WriteLine(universal[i].GetType());
				WriteLine(universal[i]);
			}


			ReadLine();
		}
	}
}