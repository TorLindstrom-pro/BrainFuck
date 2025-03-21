using BrainFuck;
using FluentAssertions;

namespace Test;

public class EmptyOutputTests
{
    [Fact(DisplayName = "Ignore input, returning nothing")]
    public void IgnoreInput()
    {
        // act
        var result = Kata.BrainLuck("", "a");
        
        // assert
        result.Should().Be("");
    }

    [Fact(DisplayName = "Empty output if never printing")]
    public void EmptyOutputIfNoPrintCommands()
    {
        // act
        var result = Kata.BrainLuck("+-,", "a");
        
        // assert
        result.Should().Be("");
    }
}