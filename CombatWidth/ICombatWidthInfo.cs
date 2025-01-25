namespace CombatWidthCalculator.CombatWidth;

public interface ICombatWidthInfo {
	public Dictionary<Province, ICombatWidthEfficiency> GetInfo();
	public string GetAdditionalLine();
}