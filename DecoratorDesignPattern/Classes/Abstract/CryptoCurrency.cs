using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Classes.Abstract
{
    public abstract class CryptoCurrency
    {
        public string name;
        public decimal baseDifficulty = 100;
        public decimal maxblockSizeBytes = 1300000;
        public abstract void Send(decimal amount, string walletId);

    }
}
