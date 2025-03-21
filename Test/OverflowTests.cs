using BrainFuck;
using FluentAssertions;

namespace Test;

public class OverflowTests
{
	[Fact(DisplayName = "Incrementing past max value overflows to zero")]
	public void IncrementingPastMaxValueOverflowsToZero()
	{
		// act
		var result = Kata.BrainLuck(",+.", ((char)255).ToString());
		
		// assert
		result.Should().Be("\0");
	}
}