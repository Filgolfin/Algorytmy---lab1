using System.Net.Http.Headers;

namespace Algorytmy_Lab1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			

			RaportTemperatur raport1 = new RaportTemperatur();

			raport1.LiczbaPomiarow = WczytajLiczbePomiarow();
			raport1.BazaPomiarow = WczytajPomiary(raport1.LiczbaPomiarow);
			raport1.Min = ZnajdzMin(raport1.BazaPomiarow);
			raport1.Max = ZnajdzMax(raport1.BazaPomiarow);
			raport1.Srednia = ObliczSrednia(raport1.BazaPomiarow);
			raport1.LiczbaGoraczek = PoliczGoraczke(raport1.BazaPomiarow);
			raport1.Trend = TrendTemperatur(raport1.BazaPomiarow);
			raport1.NajdluzszaSeriaGoraczki = NajdluzszaSeriaGoraczki(raport1.BazaPomiarow);
			raport1.WyswietlRaport();
		}
		static int WczytajLiczbePomiarow()
		{
			int liczbaPomiarow = 0;
			Console.WriteLine("Podaj liczbę pomiarów:");
			while (!int.TryParse(Console.ReadLine(), out liczbaPomiarow) || liczbaPomiarow <= 0)
			{
				Console.WriteLine("Podano nieprawidłowe dane. Spróbuj ponownie.");
				Console.WriteLine("Podaj liczbę pomiarów:");
			}

			return liczbaPomiarow;
		}

		static List<double> WczytajPomiary(int liczbaPomiarow)
		{
			List<double> listaTemperatur = new List<double>();

			for (int i = 0; i < liczbaPomiarow; i++)
			{
				double temperatura;
				Console.WriteLine("Podaj temperaturę ciała w zakresie 30-45 stopni:");
				while (!double.TryParse(Console.ReadLine(), out temperatura) || temperatura < 30 || temperatura > 45)
				{
					Console.WriteLine("Podałeś złą wartość temperatury");
					Console.WriteLine("Podaj wysokość temperatury ciała w zakresie 30-45 stopni");
				}
				listaTemperatur.Add(temperatura);

			}
			return listaTemperatur;
		}

		static double ZnajdzMin(List<double> listaTemperatur)
		{
			double minimalnaTemperatura = listaTemperatur[0];

			for (int i = 1; i < listaTemperatur.Count; i++)
			{
				if (minimalnaTemperatura > listaTemperatur[i])
				{
					minimalnaTemperatura = listaTemperatur[i];
				}
			}
			return minimalnaTemperatura;
		}

		static double ZnajdzMax(List<double> listaTemperaur)
		{
			double maksymalnaTemperatura = listaTemperaur[0];

			for (int i = 1; i < listaTemperaur.Count; i++)
			{
				if (maksymalnaTemperatura < listaTemperaur[i])
				{
					maksymalnaTemperatura = listaTemperaur[i];
				}
			}
			return maksymalnaTemperatura;
		}

		static double ObliczSrednia(List<double> listaTemperatur)
		{
			double sumaTemperatur = 0;


			for (int i = 0; i < listaTemperatur.Count; i++)
			{
				sumaTemperatur += listaTemperatur[i];
			}
			double sredniaTemperatur = sumaTemperatur / listaTemperatur.Count;

			return sredniaTemperatur;

		}

		static int PoliczGoraczke(List<double> listaTemperatur)
		{
			int goraczkaLiczba = 0;

			for (int i = 0; i < listaTemperatur.Count; i++)
			{
				if (listaTemperatur[i] > 38)
				{
					goraczkaLiczba++;
				}
			}
			return goraczkaLiczba;
		}

		static string TrendTemperatur(List<double> listaTemperatur)
		{
			int trendRosnacy = 0;
			int trendMalejacy = 0;
			double temperaturaPomiaru = listaTemperatur[0];
			string trend;

			for (int i = 1; i < listaTemperatur.Count; i++)
			{
				if (temperaturaPomiaru < listaTemperatur[i])
				{
					trendRosnacy++;

				}
				else if (temperaturaPomiaru > listaTemperatur[i])
				{
					trendMalejacy++;
				}
				temperaturaPomiaru = listaTemperatur[i];
			}

			if (trendRosnacy == listaTemperatur.Count - 1)
			{
				trend = "rosnący";
			}
			else if (trendMalejacy == listaTemperatur.Count - 1)
			{
				trend = "malejący.";
			}
			else
			{
				trend = "stabilny";
			}

			return trend;
		}

		static int NajdluzszaSeriaGoraczki(List<double> listaTemperatur)
		{
			int najdluzszaSeria = 0;
			int biezacaSeria = 0;

			for (int i = 0; i < listaTemperatur.Count; i++)
			{
				if (listaTemperatur[i] > 38)
				{
					biezacaSeria++;
					if (biezacaSeria > najdluzszaSeria)
					{
						najdluzszaSeria = biezacaSeria;
					}
				}
				else
				{
					biezacaSeria = 0;
				}
			}

			return najdluzszaSeria;
		}

	}
}
