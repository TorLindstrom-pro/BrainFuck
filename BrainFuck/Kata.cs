using System.Text;

namespace BrainFuck;

public class Kata
{
	public static string BrainLuck(string code, string input)
	{
		var resultBuilder = new StringBuilder();
		var inputPointer = -1;
		var value = '\0';
		
		foreach (var command in code)
		{
			switch (command)
			{
				case '.':
					resultBuilder.Append(value);
					break;
				case ',':
					value = input[++inputPointer];
					break;
				case '+':
					value++;
					break;
				case '-':
					value--;
					break;
			}
		}
		
		return resultBuilder.ToString();
	}
}