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
        //Statik tek instancetır. Derleme zamanında instance alır
        //Elinle instance alamazsın
        //Yapılan her şey static class ın referansı üzerinden değiştirilir
        //Static tek referansdır.
        //Herhangi bir değişiklik yapıldığında o referans değişir
        //Static bir değişkenin her zaman değer ataması yapılır
        //Static tanımlanan yapıcı metot normal yapıcı metotdan önce çalışır

        //Staic kullanımının faydası ise tek instance olduğu için belleği şişirmez.
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
