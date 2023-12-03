using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern.Flywieght
{
    public class CryptoCurrencyFactory
    {
        private Dictionary<string, ICryptoCurrency> _cryptoCurrencies = new Dictionary<string, ICryptoCurrency>();

        public ICryptoCurrency GetCryptoCurrency(string symbol)
        {
            if (!_cryptoCurrencies.ContainsKey(symbol))
            {
                _cryptoCurrencies[symbol] = new CryptoCurrency(symbol);
                Console.WriteLine($"Creating Cryptocurrency object for: {symbol}");
            }

            return _cryptoCurrencies[symbol];
        }
    }
}
