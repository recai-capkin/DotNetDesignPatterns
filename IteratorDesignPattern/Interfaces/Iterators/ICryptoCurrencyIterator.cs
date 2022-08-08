using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.Classes.Interfaces.Iterators
{
    public interface ICryptoCurrencyIterator
    {
        CryptoCurrency First();
        CryptoCurrency MoveNext();
        bool IsContinue { get; }
        CryptoCurrency current { get; }
    }
}
