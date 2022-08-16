using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Interfaces
{
    public interface IErc20
    {
        bool mintingFinished();
        string name();
        decimal totalSupply();
        string symbol();
        string owner();
    }
}
