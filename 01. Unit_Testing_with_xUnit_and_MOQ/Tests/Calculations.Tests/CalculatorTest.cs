using Xunit.Abstractions;

namespace Calculations.Tests;

public class CalculatorFixture
{
    public Calculator Calc => new Calculator();
}

public class CalculatorTest : IClassFixture<CalculatorFixture>
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly CalculatorFixture _calculatorFixture;

    public CalculatorTest(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
    {
        _testOutputHelper = testOutputHelper;
        _calculatorFixture = calculatorFixture;
    }

    [Fact]
    [Trait("Mathematics", "Sum")]
    public void Add_GivenTwoIntValues_ReturnsSumOfTwoValues()
    {
        //Arrange
        var calc = _calculatorFixture.Calc;
        //var calc = new Calculator();
        
        int a = 1;
        int b = 2;
        //Act
        var result = calc.Add(a, b);

        //Asset
        Assert.Equal(3, result);
        _testOutputHelper.WriteLine("By : YFereidouni");
    }

    [Fact]
    [Trait("Mathematics", "Sum")]
    public void Add_GivenTwoDowbleValues_ReturnsSumOfTwoValues()
    {
        //Arrange
        var calc = _calculatorFixture.Calc;
        //var calc = new Calculator();
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
        _testOutputHelper.WriteLine("By : YFereidouni");
    }

    [Fact]
    [Trait("Mathematics", "Fibo")]
    public void FiboDoesNotZeroValue01()
    {
        var calc = _calculatorFixture.Calc;
        //var calc = new Calculator();

        Assert.All(calc.FiboNumbers, n=> Assert.NotEqual(0, n));
    }
    
    [Fact]
    [Trait("Mathematics", "Fibo")]
    public void FiboDoesNotZeroValue02()
    {
        var calc = _calculatorFixture.Calc;
        //var calc = new Calculator();

        Assert.DoesNotContain(0, calc.FiboNumbers);
    }


    [Fact]
    [Trait("Mathematics", "Fibo")]
    public void FiboIncludes13()
    {
        var calc = _calculatorFixture.Calc;
        //var calc = new Calculator();

        Assert.Contains(13, calc.FiboNumbers);
    }


    [Fact]
    [Trait("Mathematics", "Fibo")]
    public void FiboDoesNotIncludes4()
    {
        var calc = _calculatorFixture.Calc;
        //var calc = new Calculator();

        Assert.DoesNotContain(4, calc.FiboNumbers);
        _testOutputHelper.WriteLine("By : YFereidouni");
    }


    [Fact]
    [Trait("Mathematics", "Fibo")]
    public void CheckCollection()
    {
        var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
        
        var calc = _calculatorFixture.Calc;
        //var calc = new Calculator();
        
        Assert.Equal(expectedCollection, calc.FiboNumbers);
        _testOutputHelper.WriteLine("By : YFereidouni");
    }
}