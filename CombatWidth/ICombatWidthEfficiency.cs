namespace CombatWidthCalculator.CombatWidth;

public interface ICombatWidthEfficiency {
	public void AddValue(int value);
	public List<int> GetEfficiency();
}