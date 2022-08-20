using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Classes.Abstract.Decorator
{
    public abstract class CryptoCurrencyDecorator:CryptoCurrency
    {
        protected CryptoCurrency _cryptoCurrency;
        public CryptoCurrencyDecorator(CryptoCurrency cryptoCurrency)
        {
            this._cryptoCurrency = cryptoCurrency;
        }
        public override void Send(decimal amount, string walletId)
        {
            if (amount != 0 && walletId != null)
            {
                _cryptoCurrency.Send(amount, walletId);
            }
        }
    }
}
