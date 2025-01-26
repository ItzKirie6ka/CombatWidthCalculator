using System.Globalization;

namespace CombatWidthCalculator.Extensions;

public static class FloatExtension {
	public static float LimitDecimalPlace(this float number,int limitPlace)
	{
		var sNumber = number.ToString(CultureInfo.InvariantCulture);
		var decimalIndex = sNumber.IndexOf('.');
		if (decimalIndex != -1) {
			sNumber = sNumber.Remove(decimalIndex + limitPlace + 1);
		}
       
		var result = float.Parse(sNumber);
		return result;
	}
}