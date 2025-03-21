using System.Collections.Generic;
using System.Text;

namespace BrainFuck;

public class Kata
{
	public static string BrainLuck(string code, string input)
	{
        var values = new char[30000];
		int valuePointer = 0, 
			inputPointer = 0;
		var loopPointers = new Stack<int>();

		var resultBuilder = new StringBuilder();

		for (var codePointer = 0; codePointer < code.Length; codePointer++)
		{
			var command = code[codePointer];
			switch (command)
			{
				case '.':
					resultBuilder.Append(values[valuePointer]);
					break;
				case ',':
					values[valuePointer] = input[inputPointer++];
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
					if (valuePointer == 0)
						valuePointer = values.Length - 1;
					else
						valuePointer--;
					break;
				case '[':
					if (values[valuePointer] == 0)
						codePointer = code.IndexOf(']', codePointer);
					loopPointers.Push(codePointer);
					break;
				case ']':
					if (values[valuePointer] > 0)
						codePointer = loopPointers.Peek();
					else
						loopPointers.Pop();
					break;
			}
		}

		return resultBuilder.ToString();
	}
}