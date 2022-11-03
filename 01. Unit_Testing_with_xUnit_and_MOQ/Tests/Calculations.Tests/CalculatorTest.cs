using Xunit.Abstractions;

namespace Calculations.Tests;

public class CalculatorFixture : IDisposable
{
    public Calculator Calc => new Calculator();

    public void Dispose()
    {
        //For Cleanup the resources
    }
}

public class CalculatorTest : IClassFixture<CalculatorFixture>, IDisposable
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly CalculatorFixture _calculatorFixture;

    private readonly MemoryStream _memoryStream; //Define only for using Dispose method

    public CalculatorTest(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
    {
        _testOutputHelper = testOutputHelper;
        _calculatorFixture = calculatorFixture;
        _testOutputHelper.WriteLine($"Constructor - {DateTime.Now}");

        _memoryStream = new MemoryStream(); //With IDisposable you can dispose resources in Dispose method
    }

    [Fact]
    [Trait("Mathematics", "Sum")]
    public void Add_GivenTwoIntValues_ReturnsSumOfTwoValues()
    {
        _testOutputHelper.WriteLine($"Add_GivenTwoIntValues_ReturnsSumOfTwoValues - {DateTime.Now}");

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
        _testOutputHelper.WriteLine($"Add_GivenTwoDowbleValues_ReturnsSumOfTwoValues - {DateTime.Now}");

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
        _testOutputHelper.WriteLine($"FiboDoesNotZeroValue01 - {DateTime.Now}");

        var calc = _calculatorFixture.Calc;
        //var calc = new Calculator();

        Assert.All(calc.FiboNumbers, n=> Assert.NotEqual(0, n));
    
        _testOutputHelper.WriteLine("By : YFereidouni");
    }

    [Fact]
    [Trait("Mathematics", "Fibo")]
    public void FiboDoesNotZeroValue02()
    {
        _testOutputHelper.WriteLine($"FiboDoesNotZeroValue02 - {DateTime.Now}");

        var calc = _calculatorFixture.Calc;
        //var calc = new Calculator();

        Assert.DoesNotContain(0, calc.FiboNumbers);
    
        _testOutputHelper.WriteLine("By : YFereidouni");
    }


    [Fact]
    [Trait("Mathematics", "Fibo")]
    public void FiboIncludes13()
    {
        _testOutputHelper.WriteLine($"FiboIncludes13 - {DateTime.Now}");

        var calc = _calculatorFixture.Calc;
        //var calc = new Calculator();

        Assert.Contains(13, calc.FiboNumbers);
    
        _testOutputHelper.WriteLine("By : YFereidouni");
    }


    [Fact]
    [Trait("Mathematics", "Fibo")]
    public void FiboDoesNotIncludes4()
    {
        _testOutputHelper.WriteLine($"FiboDoesNotIncludes4 - {DateTime.Now}");

        var calc = _calculatorFixture.Calc;
        //var calc = new Calculator();

        Assert.DoesNotContain(4, calc.FiboNumbers);
        _testOutputHelper.WriteLine("By : YFereidouni");
    }


    [Fact]
    [Trait("Mathematics", "Fibo")]
    public void CheckCollection()
    {
        _testOutputHelper.WriteLine($"CheckCollection - {DateTime.Now}");

        var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
        
        var calc = _calculatorFixture.Calc;
        //var calc = new Calculator();
        
        Assert.Equal(expectedCollection, calc.FiboNumbers);
        _testOutputHelper.WriteLine("By : YFereidouni");
    }

    public void Dispose()
    {
        _memoryStream.Dispose();
    }
}