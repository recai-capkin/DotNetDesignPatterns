using PrototypeDesignPattern.Prototypes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Prototypes.Services
{
    public class CryptoCurrency : ICryptoCurrencyPrototype
    {
        public string Symbol { get; set; }
        public decimal CurrentPrice { get; set; }
        public CryptoCurrency(string symbol, decimal price)
        {
            Symbol = symbol;
            CurrentPrice = price;
        }
        public ICryptoCurrencyPrototype Clone()
        {
            return (ICryptoCurrencyPrototype)this.MemberwiseClone();
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Currency: {Symbol}, Price: {CurrentPrice}");
        }
    }
}
