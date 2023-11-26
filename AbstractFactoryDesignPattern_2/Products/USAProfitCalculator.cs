using AbstractFactoryDesignPattern_2.Products.AbstractProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern_2.Products
{
    public class USAProfitCalculator : IProfitCalculator
    {
        public decimal CalculateProfit(decimal amount)
        {
            return amount * 0.02m;
        }
    }
}
