using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyDesignPattern.Interfaces;

namespace ProxyDesignPattern
{
    public class Exchange : IBuyCoin
    {
        public string BuyCoin(decimal amount, string currencyId)
        {
            if (amount < 10)
            {
                return currencyId+" isimli coini alabilmek için en az 10 $ yatırmalısın.";
            }
            else
            {
                return currencyId+" isimli coin alımı başarıyla yapıldı";
            }
        }
    }
}
