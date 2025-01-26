namespace CombatWidthCalculator;

public class Province : IProvince {
	public string Name { get; set; }
	public int BasicCombatWidth { get; set; }
	public int AdditionalCombatWidth { get; set; }


	public Province(string provinceName, int basicCw, int additionalCw) {
		Name = provinceName;
		BasicCombatWidth = basicCw;
		AdditionalCombatWidth = additionalCw;
	}

	public void Display() {
		Console.WriteLine($"Name: {Name}\nBasicCombatWidth: {BasicCombatWidth}\nAdditionalCombatWidth: {AdditionalCombatWidth}");
	}
}