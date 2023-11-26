using AbstractFactoryDesignPattern_2.Factories.AbstractFactoryInterfaces;
using AbstractFactoryDesignPattern_2.Products;
using AbstractFactoryDesignPattern_2.Products.AbstractProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern_2.Factories
{
    public class USAExchangeFactory : ICryptoExchangeFactory
    {
        public IProfitCalculator CreateProfitCalculator()
        {
            return new USAProfitCalculator();
        }

        public ITaxCalculator CreateTaxCalculator()
        {
            return new USATaxCalculator();
        }
    }
}
