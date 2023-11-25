using CompositeDesignPattern.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Services
{
    public class CryptoCurrency : ICryptoCurrency
    {
        public string Name { get; private set; }

        public decimal TotalValue { get; private set; }
        public CryptoCurrency(string name, decimal value)
        {
            Name = name;
            TotalValue = value;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name}: Toplam Değer = {TotalValue}");
        }
    }
}
