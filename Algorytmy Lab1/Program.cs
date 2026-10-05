namespace Algorytmy_Lab1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int liczbaPomiarow = WczytajLiczbePomiarow();
			List<double> bazaPomiarow = WczytajPomiary(liczbaPomiarow);
			double minTemperatura = ZnajdzMin(bazaPomiarow);
			double maxTemperatura = ZnajdzMax(bazaPomiarow);
			double sredniaTemperatura = ObliczSrednia(bazaPomiarow);
			int liczbaGoraczek = PoliczGoraczke(bazaPomiarow);
			string trendTemperatur = TrendTemperatur(bazaPomiarow);
			int najdluzszaSeriaGoraczek = NajdluzszaSeriaGoraczki(bazaPomiarow);
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

		static double ZnajdzMax(List<double> listaTemperatr)
		{
			double maksymalnaTemperatura = listaTemperatr[0];

			for (int i = 1; i < listaTemperatr.Count; i++)
			{
				if (maksymalnaTemperatura < listaTemperatr[i])
				{
					maksymalnaTemperatura = listaTemperatr[i];
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
				trend = "Trend jest rosnący";
			}
			else if (trendMalejacy == listaTemperatur.Count - 1)
			{
				trend = "Trend jest malejący.";
			}
			else
			{
				trend = "Trend jest stabilny";
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
