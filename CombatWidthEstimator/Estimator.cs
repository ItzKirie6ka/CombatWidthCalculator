using CombatWidthCalculator.CombatWidth;
using CombatWidthCalculator.Utilities;

namespace CombatWidthCalculator.CombatWidthEstimator;

public class Estimator : IEstimator {
	private const int DIRECTIONS = 6;
	private readonly List<Province>? _provinces; 
	
	
	public Estimator() {
		JsonUtility.Read(Program.filePath, out _provinces);
	}
	
	public CombatWidthInfo Estimate(int value) {
		var combatWidthEfficiency = new List<ICombatWidthEfficiency>();
		
		if (_provinces != null)
			foreach (var province in _provinces) {
				var efficiency = new CombatWidthEfficiency(DIRECTIONS); 
				for (var j = 1; j <= DIRECTIONS; j++) {
					efficiency.AddValue(
						(province.basicCombatWidth + province.additionalCombatWidth * (j - 1)) % value);
				}
				combatWidthEfficiency.Add(efficiency);
			}
		return new CombatWidthInfo(_provinces!, combatWidthEfficiency, DIRECTIONS);
	}
}