using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Classes.Abstract
{
    public abstract class CryptoCurrency
    {
        protected string name;
        protected decimal baseDifficulty = 100;
        protected decimal maxblockSizeBytes = 1300000;
        public abstract void Send(decimal amount, string walletId);

    }
}
