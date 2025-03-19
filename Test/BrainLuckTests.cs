using BrainFuck;
using FluentAssertions;

namespace Test;

public class BrainLuckTests
{
    [Fact]
    public void Test1()
    {
        // act
        var result = Kata.BrainLuck("", "");
        
        // assert
        result.Should().Be("");
    }
}