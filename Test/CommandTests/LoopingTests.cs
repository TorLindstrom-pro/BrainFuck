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
	public void SkipLoopIfValueIsZero()
	{
	    // act
	    var result = Kata.BrainLuck("[>++<]>.", "");
	
	    // assert
	    result.Should().Be("\0");
	}

	[Fact(DisplayName = "If value at pointer is zero, skip nested loops as well")]
	public void SkipNestedLoopsIfValueIsZero()
	{
	    // act
	    var result = Kata.BrainLuck("[>++[>++<-]<]>>.", "");
	
	    // assert
	    result.Should().Be("\0");
	}
}