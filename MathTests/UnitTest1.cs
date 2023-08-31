using System;
using Math;

namespace MathTests;

public class UnitTest1
{
    [Fact(DisplayName = "Given integer numbers, sum should succeed")]
    public void Test_Add()
    {
        //Arrange
        const int resultExpected = 4;
        const int pOne = 1;
        const int pTwo = 3;

        //act
        var resultActual = Class1.Add(pOne,pTwo);
        
        //Assert
        Assert.Equal(resultExpected, resultActual);
    }
    
    [Fact(DisplayName = "Given integer numbers, subtract should succeed")]
    public void Test_Subtract()
    {
         //Arrange
        const int resultExpected = 4;
        const int pOne = 9;
        const int pTwo = 5;

        //act
        var resultActual = Class1.Subtract(pOne,pTwo);
        
        //Assert
        Assert.Equal(resultExpected, resultActual);
    }
    [Fact(DisplayName = "Given integer numbers, multiply should succeed")]
    public void Test_Multiply()
    {
        //Arrange
        const int resultExpected = 20;
        const int pOne = 2;
        const int pTwo = 10;

        //act
        var resultActual = Class1.Multiply(pOne,pTwo);
        
        //Assert
        Assert.Equal(resultExpected, resultActual);
    }
    [Fact(DisplayName = "Given integer numbers, divide should succeed")]
    public void Test_Divide()
    {
        //Arrange
        const int resultExpected = 2;
        const int pOne = 10;
        const int pTwo = 5;

        //act
        var resultActual = Class1.Divide(pOne,pTwo);
        
        //Assert
        Assert.Equal(resultExpected, resultActual);
        
    }
}