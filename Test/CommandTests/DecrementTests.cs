using BrainFuck;
using FluentAssertions;

namespace Test.CommandTests;

public class DecrementTests
{
	[Fact(DisplayName = "Decrement single letter")]
	public void DecrementSingleLetter()
	{
		// act
		var result = Kata.BrainLuck(",-.", "b");
        
		// assert
		result.Should().Be("a");
	}

	[Fact(DisplayName = "Decrement non-contiguous letters")]
	public void DecrementTwoLetters()
	{
		// act
		var result = Kata.BrainLuck(",-.,,-.", "efg");
        
		// assert
		result.Should().Be("df");
	}
}