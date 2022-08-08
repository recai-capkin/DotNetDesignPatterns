using BuilderDesignPattern.Class.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Class
{
    public class Exchange
    {
        public void Construct(CryptoCurrencyBuilder cryptoCurrencyBuilder)
        {
            cryptoCurrencyBuilder.BuildCurrencyName();
            cryptoCurrencyBuilder.BuildCurrencySupply();
            cryptoCurrencyBuilder.BuildCurrencyAlgorithm();
            cryptoCurrencyBuilder.BuildCurrencyPrice();
        }
    }
}
