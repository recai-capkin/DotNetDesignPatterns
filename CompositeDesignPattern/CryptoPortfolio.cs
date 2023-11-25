using CompositeDesignPattern.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class CryptoPortfolio : ICryptoCurrency
    {
        private List<ICryptoCurrency> _children = new List<ICryptoCurrency>();
        public string Name { get; private set; }

        public decimal TotalValue => _children.Sum(c => c.TotalValue);
        public CryptoPortfolio(string name)
        {
            Name = name;
        }
        public void AddCurrency(ICryptoCurrency currency)
        {
            _children.Add(currency);
        }

        public void RemoveCurrency(ICryptoCurrency currency)
        {
            _children.Remove(currency);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} Portfolio: Total Portfolio Value = {TotalValue}");
            foreach (var child in _children)
            {
                child.DisplayInfo();
            }
        }

    }
}
