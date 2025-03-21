using BrainFuck;
using FluentAssertions;

namespace Test;

public class ValueWrappingTests
{
	[Fact(DisplayName = "Incrementing past max value overflows to zero")]
	public void IncrementingPastMaxValueOverflowsToZero()
	{
		// act
		var result = Kata.BrainLuck(",+.", ((char)255).ToString());
		
		// assert
		result.Should().Be("\0");
	}

	[Fact(DisplayName = "Decrementing lower than zero underflows to max value")]
	public void DecrementingLowerThanZeroUnderflowsToMaxValue()
	{
		// act
		var result = Kata.BrainLuck(",-.", ((char)0).ToString());
		
		// assert
		result.Should().Be(((char)255).ToString());
	}
}