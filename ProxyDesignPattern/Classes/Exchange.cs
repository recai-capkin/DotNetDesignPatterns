using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class Exchange
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
