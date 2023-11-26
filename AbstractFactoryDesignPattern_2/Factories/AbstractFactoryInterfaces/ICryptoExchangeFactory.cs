using AbstractFactoryDesignPattern_2.Products.AbstractProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern_2.Factories.AbstractFactoryInterfaces
{
    public interface ICryptoExchangeFactory
    {
        IProfitCalculator CreateProfitCalculator();
        ITaxCalculator CreateTaxCalculator();
    }
}
