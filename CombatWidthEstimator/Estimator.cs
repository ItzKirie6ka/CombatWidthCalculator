using CombatWidthCalculator.CombatWidth;
using CombatWidthCalculator.Utilities;
using CombatWidthCalculator.Extensions;

namespace CombatWidthCalculator.CombatWidthEstimator;

public class Estimator : IEstimator {
	private const int DIRECTIONS = 6;
	private readonly List<IProvince>? _provinces; 
	
	
	public Estimator() {
		JsonUtility.Read(Program.filePath, out List<Province>? provinces);

		_provinces = [];

		foreach (var province in provinces!) {
			_provinces.Add(province);
		}
	}
	
	public CombatWidthInfo Estimate(float value) {
		var combatWidthEfficiency = new List<ICombatWidthEfficiency>();

		if (_provinces != null)
			foreach (var province in _provinces) {
				ICombatWidthEfficiency efficiency = new CombatWidthEfficiency(DIRECTIONS); 
				for (var j = 1; j <= DIRECTIONS; j++) {
					efficiency.AddValue(
						((province.BasicCombatWidth + province.AdditionalCombatWidth * (j - 1)) % value).LimitDecimalPlace(1));
				}
				combatWidthEfficiency.Add(efficiency);
			}
		return new CombatWidthInfo(_provinces!, combatWidthEfficiency, DIRECTIONS);
	}
}