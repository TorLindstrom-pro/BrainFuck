using BrainFuck;
using FluentAssertions;

namespace Test.CommandTests;

public class EchoTests
{
	[Fact(DisplayName = "Echo single letter")]
	public void EchoSingleLetter()
	{
		// act
		var result = Kata.BrainLuck(",.", "ab");
        
		// assert
		result.Should().Be("a");
	}

	[Fact(DisplayName = "Echo two letters")]
	public void EchoTwoLetters()
	{
		// act
		var result = Kata.BrainLuck(",.,.", "ab");
        
		// assert
		result.Should().Be("ab");
	}

	[Fact(DisplayName = "Echo non-contiguous letters")]
	public void EchoNonContiguousLetters()
	{
		// act
		var result = Kata.BrainLuck(",.,,.", "abc");
        
		// assert
		result.Should().Be("ac");
	}
}