using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Tests;

[CollectionDefinition("Customer")]
public class CustomerFixtureCollection:ICollectionFixture<CustomerFixture>
{

}

public class CustomerFixture
{
    public Customer Customer => new Customer();
}
