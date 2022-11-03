using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations;

public class Customer
{
    public string Name => "Yasser";
    public int Age => 37;

    public int GetOrderByName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Error Happend!");
        }

        return 100;
    }
}
