using System.Text;

namespace CombatWidthCalculator.CombatWidth;

public class CombatWidthInfo : ICombatWidthInfo {
	private readonly int _directions;
	
	private readonly Dictionary<Province, ICombatWidthEfficiency> _info;
	
	
	public CombatWidthInfo(List<Province> provinces, List<ICombatWidthEfficiency> stats, int dirs) {
		_directions = dirs;
		_info = new Dictionary<Province, ICombatWidthEfficiency>();
		
		for (var i = 0; i < stats.Count; i++) {
			_info.Add(provinces[i%provinces.Count], stats[i]);
		}
	}

	public Dictionary<Province, ICombatWidthEfficiency> GetInfo() {
		return _info;
	}

	public string GetAdditionalLine() {
		var builder = new StringBuilder();
		
		builder.Append("Directions");
		for (var i = 0; i < _directions; i++) {
			builder.Append($"\t{i+1}");
		}
		
		return builder.ToString();
	}
}
