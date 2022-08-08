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
            _exchange = new Exchange();
            return _exchange.BuyCoin(amount, coinId);
        }
    }
}
