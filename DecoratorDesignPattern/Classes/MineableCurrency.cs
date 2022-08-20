using DecoratorDesignPattern.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Classes
{
    public class MineableCurrency : CryptoCurrency
    {
        public override void Send(decimal amount, string walletId)
        {
            Console.WriteLine(walletId + " adresine " + amount + " miktar coin gönderildi");
        }
        public string RunMining(int hashRate)
        {
            Random random = new Random();
            return name+" coini "+random.Next(0,hashRate)+" miktarında mine edildi";
        }
    }
}
