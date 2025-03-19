namespace BrainFuck;

public class Kata
{
	public static string BrainLuck(string code, string input)
	{
		var chars = input.ToCharArray().Select(c => ++c);
		return string.Join("", chars);
	}
}