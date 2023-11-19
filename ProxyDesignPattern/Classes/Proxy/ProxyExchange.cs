using ProxyDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.Classes.Proxy
{
    public class ProxyExchange : IBuyCoin
    {
        Exchange _exchange;
        public string BuyCoin(decimal amount, string coinId)
        {
            //Exchange nesnesinin yalnızca ihtiyaç olduğu durumda oluşturmak için Lazy Initialization prensini kullanılmıştır.
            if (_exchange == null)
            {
                _exchange = new Exchange();
            }
            LogTransaction(amount, coinId);
            return _exchange.BuyCoin(amount, coinId);
        }
        private void LogTransaction(decimal amount, string coinId)
        {
            Console.WriteLine($"Log: {amount} $ lık {coinId} satın alındı.");
        }
    }
}
