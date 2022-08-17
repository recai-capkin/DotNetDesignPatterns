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
    }
}
