using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WpfAutoSerialisieren
{
	[Serializable()]
	class Auto
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
		
	}
}
