namespace CombatWidthCalculator.CombatWidth;

public class CombatWidthEfficiency : ICombatWidthEfficiency {
	private readonly List<float> _efficiency;
	
	
	public CombatWidthEfficiency(int dirs) {
		_efficiency = new List<float>(dirs);
	}

	public void AddValue(float value) {
		_efficiency.Add(value);
	}

	public List<float> GetEfficiency() {
		return _efficiency; 
	}
}