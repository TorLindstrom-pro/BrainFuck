using BrainFuck;
using FluentAssertions;

namespace Test;

public class BrainLuckTests
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

    [Fact(DisplayName = "Ignore input, returning nothing")]
    public void IgnoreInput()
    {
        // act
        var result = Kata.BrainLuck("", "a");
        
        // assert
        result.Should().Be("");
    }
}