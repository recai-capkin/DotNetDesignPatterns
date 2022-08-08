using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Class.Builder.Coins
{
    public class MinaBuilder : CryptoCurrencyBuilder
    {
        public MinaBuilder()
        {
            _cryptoCurrency = new CryptoCurrency();
        }
        public override void BuildCurrencyAlgorithm()
        {
            _cryptoCurrency.CurrencyAlgorithm = "POS";
        }

        public override void BuildCurrencyName()
        {
            _cryptoCurrency.CurrencyName = "Mina";
        }

        public override void BuildCurrencyPrice()
        {
            _cryptoCurrency.CurrencyPrice = 0.66m;
        }

        public override void BuildCurrencySupply()
        {
            _cryptoCurrency.CurrencySupply = 824104972;
        }
    }
}
