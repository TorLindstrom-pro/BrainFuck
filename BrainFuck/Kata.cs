using System.Collections.Generic;
using System.Text;

namespace BrainFuck;

public class Kata
{
	public static string BrainLuck(string code, string input)
	{
        var values = new char[30000];
		var valuePointer = 0;
		var inputPointer = -1;
		var loopPointer = 0;
		var loopPointers = new Stack<int>();

		var resultBuilder = new StringBuilder();

		for (var index = 0; index < code.Length; index++)
		{
			var command = code[index];
			switch (command)
			{
				case '.':
					resultBuilder.Append(values[valuePointer]);
					break;
				case ',':
					values[valuePointer] = input[++inputPointer];
					break;
				case '+':
					if (values[valuePointer] == 255)
						values[valuePointer] = (char)0;
					else
						values[valuePointer]++;
					break;
				case '-':
					if (values[valuePointer] == 0)
						values[valuePointer] = (char)255;
					else
						values[valuePointer]--;
					break;
				case '>':
					valuePointer++;
					break;
				case '<':
					valuePointer--;
					break;
				case '[':
					loopPointers.Push(index);
					break;
				case ']':
					if (values[valuePointer] > 0)
						index = loopPointers.Peek();
					else
						loopPointers.Pop();
					break;
			}
		}

		return resultBuilder.ToString();
	}
}