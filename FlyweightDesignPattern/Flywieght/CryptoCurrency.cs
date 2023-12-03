using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern.Flywieght
{
    public class CryptoCurrency : ICryptoCurrency
    {
        private readonly string _symbol; // Intrinsic state

        public CryptoCurrency(string symbol)
        {
            _symbol = symbol;
        }

        public void DisplayPrice(double price)
        {
            Console.WriteLine($"Cryptocurrency: {_symbol}, Current Price: ${price}");
        }
    }
}
