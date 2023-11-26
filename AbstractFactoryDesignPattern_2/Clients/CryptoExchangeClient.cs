using AbstractFactoryDesignPattern_2.Factories.AbstractFactoryInterfaces;
using AbstractFactoryDesignPattern_2.Products.AbstractProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern_2.Clients
{
    public class CryptoExchangeClient
    {
        private readonly IProfitCalculator _profitCalculator;
        private readonly ITaxCalculator _taxCalculator;
        public CryptoExchangeClient(ICryptoExchangeFactory factory)
        {
            _profitCalculator = factory.CreateProfitCalculator();
            _taxCalculator = factory.CreateTaxCalculator();
        }
        public void ExecuteTrade(decimal tradeAmount)
        {
            var profit = _profitCalculator.CalculateProfit(tradeAmount);
            var tax = _taxCalculator.CalculateTax(profit);
            Console.WriteLine($"Trade Executed. Profit: {profit} - Tax: {tax}");
        }
    }
}
