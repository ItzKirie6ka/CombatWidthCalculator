using CombatWidthCalculator.CombatWidth;

namespace CombatWidthCalculator.InfoFormater;

public interface IFormater {
	public string Format(ICombatWidthInfo combatWidthInfo);
}