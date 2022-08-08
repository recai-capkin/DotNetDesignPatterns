using IteratorDesignPattern.Classes.Interfaces.Collection;
using IteratorDesignPattern.Classes.Interfaces.Iterators;
using IteratorDesignPattern.Classes.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.Classes.Collections
{
    internal class CryptoCurrencyCollection : ICryptoCurrencyCollection
    {
        private List<CryptoCurrency> _cryptoCurrencies = new List<CryptoCurrency>();

        public int CryptoCurrencyCount
        {
            get { return _cryptoCurrencies.Count; }
        }
        public CryptoCurrency this[int index]
        {
            get { return _cryptoCurrencies[index]; }
            set { _cryptoCurrencies.Add(value); }
        }
        public ICryptoCurrencyIterator GetIterator()
        {
            return new CryptoCurrencyIterator(this);
        }
    }
}
