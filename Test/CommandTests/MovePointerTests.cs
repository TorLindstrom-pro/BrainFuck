using BrainFuck;
using FluentAssertions;

namespace Test.CommandTests;

public class MovePointerTests
{
	[Fact(DisplayName = "> moves value pointer to the right")]
	public void MovePointerRight()
	{
		// act
		var result = Kata.BrainLuck(",>.", "a");
        
		// assert
		result.Should().Be("\0");
	}

	[Fact(DisplayName = "< moves value pointer to the left")]
	public void MovePointerLeft()
	{
		// act
		var result = Kata.BrainLuck(",><.", "a");
        
		// assert
		result.Should().Be("a");
	}

	[Fact(DisplayName = "moving pointer to outside of the leftmost cell wraps around to last cell")]
	public void MovePointerOutsideTheLeftmostCell()
	{
		// act
		var result = Kata.BrainLuck("<<<+.", "");
		
		// assert
		result.Should().Be(((char)1).ToString());
	}
}