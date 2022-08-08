using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.Interfaces
{
    public interface IBuyCoin
    {
        string BuyCoin(decimal amount, string coinId);
    }
}
