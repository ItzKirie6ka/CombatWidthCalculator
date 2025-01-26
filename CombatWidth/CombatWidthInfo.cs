using System.Text;

namespace CombatWidthCalculator.CombatWidth;

public class CombatWidthInfo : ICombatWidthInfo {
	private readonly int _directions;
	
	private readonly Dictionary<IProvince, ICombatWidthEfficiency> _info;
	
	
	public CombatWidthInfo(List<IProvince> provinces, List<ICombatWidthEfficiency> stats, int dirs) {
		_directions = dirs;
		_info = new Dictionary<IProvince, ICombatWidthEfficiency>();
		
		for (var i = 0; i < stats.Count; i++) {
			_info.Add(provinces[i%provinces.Count], stats[i]);
		}
	}

	public Dictionary<IProvince, ICombatWidthEfficiency> GetInfo() {
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
