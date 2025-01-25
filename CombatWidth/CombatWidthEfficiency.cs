namespace CombatWidthCalculator.CombatWidth;

public class CombatWidthEfficiency : ICombatWidthEfficiency {
	private List<int> _efficiency;
	
	
	public CombatWidthEfficiency(int dirs) {
		_efficiency = new List<int>(dirs);
	}

	public void AddValue(int value) {
		_efficiency.Add(value);
	}

	public List<int> GetEfficiency() {
		return _efficiency; 
	}
}