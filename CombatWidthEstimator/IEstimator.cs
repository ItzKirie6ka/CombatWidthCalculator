using CombatWidthCalculator.CombatWidth;

namespace CombatWidthCalculator.CombatWidthEstimator;

public interface IEstimator {
	public CombatWidthInfo Estimate(float value);
}