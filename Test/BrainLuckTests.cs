﻿using BrainFuck;
using FluentAssertions;

namespace Test;

public class BrainLuckTests
{
    [Fact(DisplayName = "Echo single letter")]
    public void EchoSingleLetter()
    {
        // act
        var result = Kata.BrainLuck(",.", "a");
        
        // assert
        result.Should().Be("a");
    }
}