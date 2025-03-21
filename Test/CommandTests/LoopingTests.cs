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

	[Fact(DisplayName = "Nested loops work")]
	public void NestedLoopsWork()
	{
	    // act
	    var result = Kata.BrainLuck("+++[>+++[>+<-]<-]>>.", "");
	
	    // assert
	    result.Should().Be("\u0009");
	}

	[Fact(DisplayName = "If value at pointer is zero, skip loop")]
	public void NestedLoopsWork2()
	{
	    // act
	    var result = Kata.BrainLuck("[>++<]>.", "");
	
	    // assert
	    result.Should().Be("\0");
	}
}