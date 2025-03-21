using BrainFuck;
using FluentAssertions;

namespace Test.CommandTests;

public class LoopingTests
{
	[Fact(DisplayName = "Verify simple loop increments and decrements correctly")]
	public void VerifySimpleLoopWorks()
	{
	    // act
	    var result = Kata.BrainLuck("+++[>+<-]>.", "");
	
	    // assert
	    result.Should().Be("\u0003");
	}
}