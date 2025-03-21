using BrainFuck;
using FluentAssertions;

namespace Test.CommandTests;

public class IncrementTests
{
	[Fact(DisplayName = "Increment single letter")]
	public void IncrementSingleLetter()
	{
		// act
		var result = Kata.BrainLuck(",+.", "a");
        
		// assert
		result.Should().Be("b");
	}

	[Fact(DisplayName = "Increment non-contiguous letters")]
	public void IncrementTwoLetters()
	{
		// act
		var result = Kata.BrainLuck(",+.,,+.", "abc");
        
		// assert
		result.Should().Be("bd");
	}
}