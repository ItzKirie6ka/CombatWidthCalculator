using System.Text;
using CombatWidthCalculator.CombatWidth;
using CombatWidthCalculator.Extensions;
using CombatWidthCalculator.Utilities;
using Pastel;

namespace CombatWidthCalculator.InfoFormater;

public class ColoredFormater : IFormater {
	public string Format(ICombatWidthInfo combatWidthInfo) {
		var info = combatWidthInfo.GetInfo();
		var additionalLine = combatWidthInfo.GetAdditionalLine();
		var offset = additionalLine.GetFirstWord().Length;
		var builder = new StringBuilder();
		
		builder.Append(additionalLine);

		foreach (var pair in info) {
			builder.Append($"\n{pair.Key.name}");
			for (var i = 0; i < offset - pair.Key.name.Length; i++)
				builder.Append(' ');
			foreach (var efficiency in pair.Value.GetEfficiency()) {
				builder.Append($"\t{efficiency}".Pastel(DetermineColor(efficiency)));
			}
		}
		return builder.ToString();
	}

	private string? DetermineColor(int value) {
		var color = value switch {
			0 => Color.Green.ToEnumMember(),
			>= 5 and <= 10 => Color.Yellow.ToEnumMember(),
			> 10 => Color.Red.ToEnumMember(),
			_ => Color.Green.ToEnumMember()
		};
		
		return color;
	}
}