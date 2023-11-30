using AdapterDesignPattern.CryptoCurrencyAdapterProject.Interfaces;
using AdapterDesignPattern.CryptoCurrencyAdapterProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.CryptoCurrencyAdapterProject.Adapters
{
    public class BitcoinAdapter : ICryptoCurrencyAPI
    {
        private BitcoinService _bitcoinService;

        public BitcoinAdapter(BitcoinService bitcoinService)
        {
            _bitcoinService = bitcoinService;
        }
        public decimal GetPrice()
        {
            // Convert the price from BTC to a standard currency, e.g., USD
            decimal priceInBTC = _bitcoinService.GetPriceInBTC();
            decimal btcToUsdRate = 20000; // Let's assume 1 BTC = 20,000 USD
            return priceInBTC * btcToUsdRate;
        }
    }
}
