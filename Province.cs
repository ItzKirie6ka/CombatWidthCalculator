namespace CombatWidthCalculator;

public class Province {
	public string name;
	public int basicCombatWidth;
	public int additionalCombatWidth;
	
	
	public Province(string provinceName, int basicCW, int additionalCW) {
		name = provinceName;
		basicCombatWidth = basicCW;
		additionalCombatWidth = additionalCW;
	}

	public void Display() {
		Console.WriteLine($"Name: {name}\nBasicCombatWidth: {basicCombatWidth}\nAdditionalCombatWidth: {additionalCombatWidth}");
	}
}