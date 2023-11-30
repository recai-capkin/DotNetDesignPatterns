using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.CryptoCurrencyAdapterProject.Services
{
    public class EthereumService
    {
        public decimal GetPriceInUSD()
        {
            // Imagine this method actually reaches out to an Ethereum service
            return 200.00m; // Dummy price in USD
        }
    }
}
