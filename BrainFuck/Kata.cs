using System.Collections.Generic;
using System.Text;

namespace BrainFuck;

public class Kata
{
	public static string BrainLuck(string code, string input)
	{
		var resultBuilder = new StringBuilder();
		var valuePointer = 0;
        var values = new char[30000];
		var inputPointer = -1;

		foreach (var command in code)
		{
			switch (command)
			{
				case '.':
					resultBuilder.Append(values[valuePointer]);
					break;
				case ',':
					values[valuePointer] = input[++inputPointer];
					break;
				case '+':
					values[valuePointer]++;
					break;
				case '-':
					values[valuePointer]--;
					break;
				case '>':
					valuePointer++;
					break;
				case '<':
					valuePointer--;
					break;
			}
		}
		
		return resultBuilder.ToString();
	}
}