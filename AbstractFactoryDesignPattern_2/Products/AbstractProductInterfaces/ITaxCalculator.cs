using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern_2.Products.AbstractProductInterfaces
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(decimal amount);
    }
}
