using System.Text;

namespace CombatWidthCalculator.Utilities;

public static class StringUtilities {
	public static string GetFirstWord(this string input) {
		var firstWord = new StringBuilder();

		foreach (var letter in input) {
			if (string.IsNullOrWhiteSpace(letter.ToString())) {
				return firstWord.ToString();
			}
			firstWord.Append(letter);
		}

		return firstWord.ToString();
	}
}