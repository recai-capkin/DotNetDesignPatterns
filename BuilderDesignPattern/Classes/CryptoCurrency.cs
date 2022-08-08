using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class CryptoCurrency
    {
        //Kripto Para adı
        public string CurrencyName { get; set; }
        //Kripto Paranın Toplam Arzı
        public decimal CurrencySupply { get; set; }
        //Kripto Para Fiyatı
        public decimal CurrencyPrice { get; set; }
        //Kripto Parada çalışan algoritma
        public string CurrencyAlgorithm { get; set; }

        public override string ToString()
        {
            return "Kripto para adı :"+CurrencyName+ "\n "+
                   "Kripto para toplam arzı :" + CurrencySupply+"\n"+
                   "Kripto para fiyatı :"+CurrencyPrice+"\n"+
                   "Kripto para algoritma türü değerlendirme :"+
                   ((CurrencyAlgorithm.ToUpper() == "POW")
                   ? "Çalışan bu algoritma yüksek enerji tüketimine sahiptir."
                   :"Pow a göre verimli bir algoritmadır");
        }

    }
}
