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

		var skippingLoop = false;
		var loopsDeep = 0;

		for (var codePointer = 0; codePointer < code.Length; codePointer++)
		{
			var command = code[codePointer];

			if (!skippingLoop)
				ExecuteCommand(command, ref codePointer);
			else
				SkipCommandOrExitLoop(command);
		}

		return resultBuilder.ToString();
		
		// Functions
		
		void ExecuteCommand(char command, ref int codePointer)
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
					IncrementOrOverflow(ref values[valuePointer]);
					break;
				case '-':
					DecrementOrUnderflow(ref values[valuePointer]);
					break;
				case '>':
					MoveRightOrWrap(ref valuePointer);
					break;
				case '<':
					MoveLeftOrWrap(ref valuePointer);
					break;
				case '[':
					skippingLoop = StartOrSkipLoop(codePointer);
					break;
				case ']':
					ContinueOrEndLoop(ref codePointer);
					break;
			}
		}
		
		void SkipCommandOrExitLoop(char command)
		{
			switch (command)
			{
				case '[':
					loopsDeep++;
					break;
				case ']':
					if (loopsDeep == 0)
						skippingLoop = false;
					else
						loopsDeep--;
					break;
			}
		}

		void IncrementOrOverflow(ref char value)
		{
			if (value == 255)
				value = (char)0;
			else
				value++;
		}

		void DecrementOrUnderflow(ref char value)
		{
			if (value == 0)
				value = (char)255;
			else
				value--;
		}

		void MoveRightOrWrap(ref int pointer)
		{
			if (pointer == values.Length - 1)
				pointer = 0;
			else
				pointer++;
		}

		void MoveLeftOrWrap(ref int pointer)
		{
			if (pointer == 0)
				pointer = values.Length - 1;
			else
				pointer--;
		}

		bool StartOrSkipLoop(int codePointer)
		{
			if (values[valuePointer] <= 0)
				skippingLoop = true;
			else
				loopPointers.Push(codePointer);
			return skippingLoop;
		}

		void ContinueOrEndLoop(ref int codePointer)
		{
			if (values[valuePointer] > 0)
				codePointer = loopPointers.Peek();
			else
				loopPointers.Pop();
		}
	}
}