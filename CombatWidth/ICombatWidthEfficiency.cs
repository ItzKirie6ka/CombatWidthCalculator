namespace CombatWidthCalculator.CombatWidth;

public interface ICombatWidthEfficiency {
	public void AddValue(float value);
	public List<float> GetEfficiency();
}