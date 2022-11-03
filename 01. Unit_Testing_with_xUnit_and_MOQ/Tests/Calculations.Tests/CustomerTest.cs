using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Calculations.Tests;

public class CustomerTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public CustomerTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    [Trait("Customer", "Fields")]
    public void CheckNameNotEmpty()
    {
        var customer = new Customer();
        Assert.NotNull(customer.Name);
        Assert.False(string.IsNullOrEmpty(customer.Name));
        
        _testOutputHelper.WriteLine("By : YFereidouni");
    }

    [Fact]
    [Trait("Customer", "Fields")]
    public void CheckLegiForDiscount()
    {
        var customer = new Customer();
        Assert.InRange(customer.Age, 20, 40);
    
        _testOutputHelper.WriteLine("By : YFereidouni");
    }

    [Fact]
    [Trait("Customer", "Exceptions")]
    public void GetOrderByNameNotNull()
    {
        //Arrange
        var customer = new Customer();
        //Act
        var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrderByName(null));
        //Assert
        Assert.Equal("Error Happend!", exceptionDetails.Message);
        
        _testOutputHelper.WriteLine("By : YFereidouni");
    }

    [Fact]
    [Trait("Customer", "Orders")]
    public void LoyalCustomerForOrdersGreaterThan100()
    {
        var customer = CustomerFactory.CreateCustomerInstance(102);
        var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
        Assert.Equal(10, loyalCustomer.Discount);
    
        _testOutputHelper.WriteLine("By : YFereidouni");
    }

    [Fact]
    [Trait("Customer", "Orders")]
    public void LoyalCustomerForOrdersLessThan100()
    {
        var customer = CustomerFactory.CreateCustomerInstance(99);
        Assert.IsType<Customer>(customer);
        
        _testOutputHelper.WriteLine("By : YFereidouni");
    }
}
