using System.Text;

namespace BrainFuck;

public class Kata
{
	public static string BrainLuck(string code, string input)
	{
		if (string.IsNullOrEmpty(code))
			return "";

		var resultBuilder = new StringBuilder();
		var inputPointer = -1;
		
		for (var i = 0; i < code.Length; i++)
		{
			if (code[i] == '.')
			{
				resultBuilder.Append(input[inputPointer]);
			}
			else if (code[i] == ',')
			{
				inputPointer++;
			}
		}
		
		return resultBuilder.ToString();
	}
}