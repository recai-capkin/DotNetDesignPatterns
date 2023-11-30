using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.CryptoCurrencyAdapterProject.Services
{
    public class BitcoinService
    {
        public decimal GetPriceInBTC()
        {
            // Imagine this method actually reaches out to a Bitcoin service
            return 0.00025m; // Dummy price in BTC
        }
    }
}
