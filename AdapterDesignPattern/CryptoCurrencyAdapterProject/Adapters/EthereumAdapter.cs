using AdapterDesignPattern.CryptoCurrencyAdapterProject.Interfaces;
using AdapterDesignPattern.CryptoCurrencyAdapterProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.CryptoCurrencyAdapterProject.Adapters
{
    public class EthereumAdapter : ICryptoCurrencyAPI
    {
        private EthereumService _ethereumService;
        public EthereumAdapter(EthereumService ethereumService)
        {
            _ethereumService = ethereumService;
        }
        public decimal GetPrice()
        {
            return _ethereumService.GetPriceInUSD();
        }
    }
}
