namespace Calculations.Tests;

public class CalculatorTest
{
    [Fact]
    public void Add_GivenTwoIntValues_ReturnsSumOfTwoValues()
    {
        //Arrange
        var calc = new Calculator();
        int a = 1;
        int b = 2;
        //Act
        var result = calc.Add(a, b);

        //Asset
        Assert.Equal(3, result);
    }

    [Fact]
    public void Add_GivenTwoDowbleValues_ReturnsSumOfTwoValues()
    {
        //Arrange
        var calc = new Calculator();
        double a = 1.23;
        double b = 3.55;
        //Act
        var result = calc.AddDouble(a, b);

        //Asset
        ///3rd parameter state that round up the result to 1 precision
        ///Expected: 4.7 
        ///Actual : 4.8 after round-up
        //Assert.Equal(4.7, result, 1); //Failed

        ///3rd parameter state that round up not applied.
        Assert.Equal(4.7, result, 0); //Passed
    }
}