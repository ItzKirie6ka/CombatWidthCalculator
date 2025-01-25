using System.Runtime.Serialization;

namespace CombatWidthCalculator.InfoFormater;

public enum Color {
	[EnumMember(Value = "#008000")]
	Green,
	[EnumMember(Value = "#FFFF00")]
	Yellow,
	[EnumMember(Value = "#FF0000")]
	Red
}