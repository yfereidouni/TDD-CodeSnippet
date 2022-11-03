using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Tests;

public class CustomerTest
{
    [Fact]
    public void CheckNameNotEmpty()
    {
        var customer = new Customer();

        Assert.NotNull(customer.Name);
        Assert.False(string.IsNullOrEmpty(customer.Name));
    }

    [Fact]
    public void CheckLegiForDiscount()
    {
        var customer = new Customer();

        Assert.InRange(customer.Age, 20, 40);
    }

    [Fact]
    public void GetOrderByNameNotNull()
    {
        var customer = new Customer();

        var result = Assert.Throws<ArgumentException>(() => customer.GetOrderByName(null));

        Assert.Equal("Error Happend!", result.Message);
    }
}
