using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.Classes
{
    public class CryptoCurrency
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public decimal CurrencyPrice { get; set; }
        public override string ToString()
        {
            return String.Format("Id numarası {0} olan {1} isimli paranın fiyatı {2} $ 'dır.",CurrencyId,CurrencyName,CurrencyPrice);
        }
    }
}
