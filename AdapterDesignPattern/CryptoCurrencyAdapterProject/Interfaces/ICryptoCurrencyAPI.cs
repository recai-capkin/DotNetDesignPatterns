using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.CryptoCurrencyAdapterProject.Interfaces
{
    public interface ICryptoCurrencyAPI
    {
        decimal GetPrice();
    }
}
