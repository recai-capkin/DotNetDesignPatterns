using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Class.Builder.Coins
{
    public class BitcoinBuilder : CryptoCurrencyBuilder
    {
        public BitcoinBuilder()
        {
            _cryptoCurrency = new CryptoCurrency();
        }
        public override void BuildCurrencyAlgorithm()
        {
            _cryptoCurrency.CurrencyAlgorithm = "POW";
        }

        public override void BuildCurrencyName()
        {
            _cryptoCurrency.CurrencyName = "Bitcoin";
        }

        public override void BuildCurrencyPrice()
        {
            _cryptoCurrency.CurrencyPrice = 0.0025m;
        }

        public override void BuildCurrencySupply()
        {
            _cryptoCurrency.CurrencySupply = 21000000;
        }
    }
}
