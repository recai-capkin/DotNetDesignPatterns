using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.Classes
{
    public sealed class BitcoinWallet
    {

       
        private BitcoinWallet() { }
        private static BitcoinWallet _instance;
        public static BitcoinWallet Instance()
        {
            if( _instance == null )
            {
                _instance = new BitcoinWallet();
            }
            return _instance;
        }
        public decimal Balance { get; private set; }
        public void AddFunds(decimal amount)
        {
            Balance += amount;
        }
        public void SendFunds(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Yetersiz bakiye.");
            }
        }
    }
}
