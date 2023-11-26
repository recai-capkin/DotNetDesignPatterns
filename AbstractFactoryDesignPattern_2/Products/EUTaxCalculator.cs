using AbstractFactoryDesignPattern_2.Products.AbstractProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern_2.Products
{
    public class EUTaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal amount)
        {
            return amount * 0.2m;
        }
    }
}
