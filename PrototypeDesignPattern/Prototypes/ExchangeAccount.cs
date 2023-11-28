using PrototypeDesignPattern.Prototypes.Services;
using PrototypeDesignPattern.Prototypes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Prototypes
{
    public class ExchangeAccount : ICryptoCurrencyPrototype
    {
        public string AccountId { get; set; }
        public List<CryptoCurrency> Portfolio { get; set; }
        public ExchangeAccount(string accountId)
        {
            AccountId = accountId;
            Portfolio = new List<CryptoCurrency>();
        }

        public ICryptoCurrencyPrototype Clone()
        {
            var clonedAccount = (ExchangeAccount)this.MemberwiseClone();
            clonedAccount.Portfolio = new List<CryptoCurrency>(this.Portfolio.Select(coin => (CryptoCurrency)coin.Clone()));
            return clonedAccount;
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account ID: {AccountId}");
            foreach (var coin in Portfolio)
            {
                coin.DisplayInfo();
            }
        }
    }
}
