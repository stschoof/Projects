using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruchRechnenConsoleApplication
{
	class Program
	{ 

		class Bruch

		{
			int zaehler;	// Attribute der Klasse
			int nenner;
			double dezimalwert;
			double ergebnis;

			

			public Bruch(int zaehler, int nenner) // Konstrukter mit zaheler und nenner 
			{
				this.zaehler = zaehler;
				this.nenner = nenner;
				
			}

			// Ab hier alle getter und setter 
			public double Ergebnis
			{
				get
				{
					return ergebnis;
				}

				set
				{
					ergebnis = value;
				}
			}

			public int Zaehler
			{
				get
				{
					return zaehler;
				}

				set
				{
					zaehler = value;
				}
			}

			public int Nenner
			{
				get
				{
					return nenner;
				}

				set
				{
					nenner = value;
					
				}
			}

			public double Dezimalwert
			{
				get
				{
					return dezimalwert;
				}

				set
				{	
					dezimalwert = value;
				}
			}

			// Ab hier alle Methoden

			public void darstellen()
			{
				
				Write("{0}/{1}", zaehler,nenner);
				WriteLine(" = {0,3:F3}",dezimal_ermitteln());
			}

			public double dezimal_ermitteln()
			{
				dezimalwert = (double)zaehler / nenner;
				return dezimalwert;
			}

			public double multiplizieren(Bruch a, Bruch b)
			{

				return Ergebnis;
			}

			public double dividieren(Bruch a, Bruch b)
			{

				return Ergebnis;
			}

			public double addieren(Bruch a, Bruch b)
			{

				return Ergebnis;
			}
			public double subtrahieren(Bruch a, Bruch b)
			{
				
				return Ergebnis;
			}


		}

		static void Main(string[] args)
		{
			// Anlegen eines Burch Objektes
			Bruch erster = new Bruch(33,67);
			Bruch zweiter = new Bruch(1, 2);
			// Ausgabe für die Methode darstellen als dezimale und als Bruch. 
			erster.darstellen();
			zweiter.darstellen();
			
			ReadLine();

		}
	}
}
