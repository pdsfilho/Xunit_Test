using System;
using Math;

namespace MathTests;

public class UnitTest2
{
    [Theory]
    [InlineData(5,1,3,7)]
    [InlineData(10,13,15,17)]
    
    public void Test_OddNumbers_WithInlineData(int a, int b, int c, int d)
    {
        Class1 class1= new Class1();
        Assert.True(class1.IsOddNumber(a));
        Assert.True(class1.IsOddNumber(b));
        Assert.True(class1.IsOddNumber(c));
        Assert.True(class1.IsOddNumber(d));
    } 
}
