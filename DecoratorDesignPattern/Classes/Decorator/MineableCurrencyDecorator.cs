using DecoratorDesignPattern.Classes.Abstract;
using DecoratorDesignPattern.Classes.Abstract.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Classes.Decorator
{
    public class MineableCurrencyDecorator:CryptoCurrencyDecorator
    {
        
        public MineableCurrencyDecorator(CryptoCurrency cryptoCurrency) : base(cryptoCurrency)
        {

        }
        public decimal changeDifficulty()
        {
            Random random = new Random();
            baseDifficulty += this.baseDifficulty * random.Next(10);
            return baseDifficulty;
        }
        public decimal changeBlockSize(decimal blok)
        {
            return maxblockSizeBytes+blok;
        }
        public override void Send(decimal amount, string walletId)
        {
            base.Send(amount, walletId);
        }
    }
}
