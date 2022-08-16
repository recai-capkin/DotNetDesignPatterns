using FactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Classes
{
    public class Dent : IErc20
    {
        private readonly string _name;
        public Dent()
        {
            this._name = "Dent";
        }
        public bool mintingFinished()
        {
            return true;
        }

        public string name()
        {
            return _name;
        }

        public string owner()
        {
            return "0xf9e42ad2e8a5a1ed07f5c3d7dfc2ca415db0fde6";
        }

        public string symbol()
        {
            return "DENT";
        }

        public decimal totalSupply()
        {
            return 100000000000.00000000m;
        }
    }
}
