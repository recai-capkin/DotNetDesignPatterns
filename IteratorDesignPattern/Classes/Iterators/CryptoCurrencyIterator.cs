using IteratorDesignPattern.Classes.Collections;
using IteratorDesignPattern.Classes.Interfaces.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.Classes.Iterators
{
    internal class CryptoCurrencyIterator : ICryptoCurrencyIterator
    {
        private CryptoCurrencyCollection _coins;
        private int _currentIndex = 0;
        public int StepSize { get; set; }
        public CryptoCurrencyIterator(CryptoCurrencyCollection cryptoCurrencyCollection)
        {
            _coins = cryptoCurrencyCollection;
        }
        public bool IsContinue
        {
            get { return _currentIndex < _coins.CryptoCurrencyCount; }
        }

        public CryptoCurrency current 
        {
            get { return _coins[_currentIndex]; }
        }

        public CryptoCurrency First()
        {
            _currentIndex = 0;
            return _coins[0];
        }

        public CryptoCurrency MoveNext()
        {
            _currentIndex += StepSize;
            if (IsContinue)
            {
                return _coins[_currentIndex];
            }
            else
            {
                return null;
            }
        }
    }
}
