using IteratorDesignPattern.Classes.Interfaces.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.Classes.Interfaces.Collection
{
    public interface ICryptoCurrencyCollection
    {
        ICryptoCurrencyIterator GetIterator();
    }
}
