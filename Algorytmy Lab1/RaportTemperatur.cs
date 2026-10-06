using System;
using System.Collections.Generic;
using System.Text;

namespace Algorytmy_Lab1
{
	internal class RaportTemperatur
	{
		public int LiczbaPomiarow { get; set; }
		public List<double> BazaPomiarow { get; set; }
		public double Min { get; set; }
		public double Max { get; set; }
		public double Srednia { get; set; }
		public int LiczbaGoraczek { get; set; }
		public string Trend { get; set; }
		public int NajdluzszaSeriaGoraczki { get; set; }
		public void WyswietlRaport()
		{
			Console.WriteLine("Raport Pomiarów");
			Console.WriteLine($"Zostało przeprowadzone {LiczbaPomiarow} pomiarów temperatury");
			Console.WriteLine($"Najniższa zanotowan tempertrura to {Min} stopni, a najwyższa {Max} stopni celcjusza.");
			Console.WriteLine($"Średnia temperatura wyniosła {Srednia}");
			Console.WriteLine($"Podczas pomiarów zanotowano {LiczbaGoraczek} pomiarów powyżej 38 stopni celcjusza.");
			Console.WriteLine($"Trend temperatur był {Trend}.");
			Console.WriteLine($"Najdłusza seria gorączek wyniosła {NajdluzszaSeriaGoraczki}.");
		}
	}
}
