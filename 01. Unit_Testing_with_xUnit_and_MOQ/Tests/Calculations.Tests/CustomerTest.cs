﻿using System;
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
        //Arrange
        var customer = new Customer();
        //Act
        var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrderByName(null));
        //Assert
        Assert.Equal("Error Happend!", exceptionDetails.Message);
    }

    [Fact]
    public void LoyalCustomerForOrdersGreaterThan100()
    {
        var customer = CustomerFactory.CreateCustomerInstance(102);
        var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
        Assert.Equal(10, loyalCustomer.Discount);
    }

    [Fact]
    public void LoyalCustomerForOrdersLessThan100()
    {
        var customer = CustomerFactory.CreateCustomerInstance(99);
        Assert.IsType<Customer>(customer);
    }
}
