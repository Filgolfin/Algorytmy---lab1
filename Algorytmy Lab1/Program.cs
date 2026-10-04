namespace Algorytmy_Lab1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int liczbaPomiarow = WczytajLiczbePomiarow();
			List<double> bazaPomiarow = WczytajPomiary(liczbaPomiarow);
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
				double temperatura = 0;
				Console.WriteLine("Podaj wysokość temperatury ciała w zakresie 30-45 stopni");
				while (!double.TryParse(Console.ReadLine(), out temperatura) || temperatura < 30 || temperatura > 45)
				{
					Console.WriteLine("Podałeś złą wartość temperatury");
					Console.WriteLine("Podaj wysokość temperatury ciała w zakresie 30-45 stopni");
				}
				listaTemperatur.Add(temperatura);

			}
			return listaTemperatur;
		}


	}
}
