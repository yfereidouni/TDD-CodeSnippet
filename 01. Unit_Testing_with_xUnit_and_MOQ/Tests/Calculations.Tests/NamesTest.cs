﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Tests;

public class NamesTest
{
    [Fact]
    public void MakeFullNameTest()
    {
        //Arrange
        var names = new Names();

        //Act
        var result = names.MakeFullName("yasser", "Fereidouni");


        //Assert
        Assert.Equal("Yasser Fereidouni", result, ignoreCase: true); //Ignore Case-Sensitive
        
        Assert.StartsWith("Yasser", result, StringComparison.InvariantCultureIgnoreCase);

        Assert.EndsWith(" fereidouni", result, StringComparison.InvariantCultureIgnoreCase);

        Assert.Matches("([A-Z]{1}[a-z]+|[a-z]+) ([A-Z]{1}[a-z]+|[a-z]+)", result);
    }
}
