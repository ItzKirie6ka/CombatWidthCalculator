namespace CombatWidthCalculator;

public interface IProvince {
	public string Name { get; }
	public int BasicCombatWidth { get; }
	public int AdditionalCombatWidth { get; }


	public void Display();
}