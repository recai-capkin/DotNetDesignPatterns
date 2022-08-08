using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Class.Builder
{
    public abstract class CryptoCurrencyBuilder
    {
        protected CryptoCurrency _cryptoCurrency;
        public CryptoCurrency CryptoCurrency { get { return _cryptoCurrency; } }
        public abstract void BuildCurrencyName();
        public abstract void BuildCurrencySupply();
        public abstract void BuildCurrencyPrice();
        public abstract void BuildCurrencyAlgorithm();

    }
}
