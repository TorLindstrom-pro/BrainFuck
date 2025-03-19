using System.Text;

namespace BrainFuck;

public class Kata
{
	public static string BrainLuck(string code, string input)
	{
		var resultBuilder = new StringBuilder();
		var inputPointer = -1;
		
		foreach (var command in code)
		{
			switch (command)
			{
				case '.':
					resultBuilder.Append(input[inputPointer]);
					break;
				case ',':
					inputPointer++;
					break;
			}
		}
		
		return resultBuilder.ToString();
	}
}