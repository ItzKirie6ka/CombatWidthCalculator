using CombatWidthCalculator.CombatWidthEstimator;
using CombatWidthCalculator.InfoFormater;
using CombatWidthCalculator.Utilities;

namespace CombatWidthCalculator;

public static class Program {
	public static readonly string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\k0nch\combatWidthData.json";
	private static readonly string _directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\k0nch\";

	private static IEstimator Estimator { get; } = new Estimator();
	private static IFormater Formater { get; } = new ColoredFormater();

	
	private static void Main() {
		var combatWidth = GetCombatWidth();
		GenerateJson();
		
		Console.Clear();
		
		var combatWidthInfo = Estimator.Estimate(combatWidth);
		Console.WriteLine(Formater.Format(combatWidthInfo));
		
		Console.ReadKey();
	}

	private static float GetCombatWidth() {
		Console.WriteLine("What's your combat width?");

		float combatWidth;
		string? input;
		var attempt = 0;

		do {
			if (attempt++ != 0) {
				Console.Clear();
				Console.WriteLine("Combat width must be a number greater than zero.");
			}

			input = Console.ReadLine();
		} while (!(float.TryParse(input, out combatWidth) && combatWidth > 0));
		
		return combatWidth;
	}

	private static void GenerateJson() {
		if (File.Exists(filePath)) {
			return;
		}
		
		Directory.CreateDirectory(_directory);
		File.Create(filePath).Close();
		
		var provinces = new List<Province> {
								new("City", 80, 40),
								new("Desert", 70, 35),
								new("Plains", 70, 35),
								new("Hills", 70, 35),
								new("Jungle", 60, 30),
								new("Forest", 60, 30),
								new("Mountains", 50, 25),
								new("Marsh", 50, 25)
							};
		
		JsonUtility.Write(filePath, provinces);
	}
}