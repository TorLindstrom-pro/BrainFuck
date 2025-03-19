using BrainFuck;
using FluentAssertions;

namespace Test;

public class BrainLuckTests
{
    [Theory(DisplayName = "Increment single input letter")]
    [InlineData("a", "b")]
    [InlineData("g", "h")]
    public void IncrementSingleLetter(string input, string expectedResult)
    {
        // act
        var result = Kata.BrainLuck(",+.", input);
        
        // assert
        result.Should().Be(expectedResult);
    }
}