namespace BrainFuck;

public class Kata
{
	public static string BrainLuck(string code, string input)
	{
		return string.IsNullOrEmpty(code) ? "" : input[..code.Count(c => c == ',')];
	}
}