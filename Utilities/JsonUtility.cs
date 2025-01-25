using Newtonsoft.Json;

namespace CombatWidthCalculator.Utilities;

public static class JsonUtility {
	private static readonly JsonSerializerSettings _options
		= new() { NullValueHandling = NullValueHandling.Ignore, 
					Formatting = Formatting.Indented };
	public static void Read<T>(string fileName, out T? obj) {
		using var sr = new StreamReader(fileName);
		obj = JsonConvert.DeserializeObject<T>(sr.ReadToEnd());
	}

	public static void Write<T>(string fileName, T data) {
		var json = JsonConvert.SerializeObject(data, _options);
		File.WriteAllText(fileName, json);
	}
}