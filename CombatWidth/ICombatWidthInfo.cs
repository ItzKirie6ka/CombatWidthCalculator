namespace CombatWidthCalculator.CombatWidth;

public interface ICombatWidthInfo {
	public Dictionary<IProvince, ICombatWidthEfficiency> GetInfo();
	public string GetAdditionalLine();
}