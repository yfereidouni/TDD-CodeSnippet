using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Calculations.Tests;

[Collection("Customer")]
public class CustomerDetailsTest
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly CustomerFixture _customerFixture;

    public CustomerDetailsTest(ITestOutputHelper testOutputHelper, CustomerFixture customerFixture)
    {
        _testOutputHelper = testOutputHelper;
        _customerFixture = customerFixture;
    }

    [Fact]
    [Trait("Customer", "Fields")]
    public void MakeFullNameNotNull()
    {
        //Arrange
        var customer = _customerFixture.Customer;
        //var customer = new Customer();

        //Act
        var fullName = customer.MakeFullName("Yasser", "Fereidouni");

        //Assert
        Assert.NotNull(fullName);
        Assert.False(string.IsNullOrEmpty(fullName));
        
        _testOutputHelper.WriteLine("By : YFereidouni");
    }

}
