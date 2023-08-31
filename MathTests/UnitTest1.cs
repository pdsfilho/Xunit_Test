using System;
using Math;

namespace MathTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var actual = Class1.Add(1,3);
        Assert.Equal(4, actual);

    }
}