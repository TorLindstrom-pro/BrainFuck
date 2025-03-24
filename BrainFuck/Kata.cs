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

		var skip = false;
		var deep = 0;

		for (var codePointer = 0; codePointer < code.Length; codePointer++)
		{
			var command = code[codePointer];

			if (skip)
			{
				switch (command)
				{
					case '[':
						deep++;
						break;
					case ']':
						if (deep == 0)
							skip = false;
						else
							deep--;
						break;
				}
			}
			else
			{
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
						if (valuePointer == values.Length - 1)
							valuePointer = 0;
						else
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
							skip = true;
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
		}

		return resultBuilder.ToString();
	}
}