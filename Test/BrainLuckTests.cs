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
    
    [Fact(DisplayName = "moving pointer to outside of the leftmost cell throws exception")]
    public void MovePointerOutsideTheLeftmostCell()
    {
        // assert
        Assert.Throws<IndexOutOfRangeException>(() => Kata.BrainLuck(",<.", "a"));
    }

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