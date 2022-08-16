using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Classes
{
    public class Tether : IErc20
    {
        private readonly string _name;
        public Tether()
        {
            this._name = "Tether USD";
        }
        public bool mintingFinished()
        {
            return false;
        }

        public string name()
        {
            return _name;
        }

        public string owner()
        {
            return "0xc6cde7c39eb2f0f0095f41570af89efc2c1ea828";
        }

        public string symbol()
        {
            return "USDT";
        }

        public decimal totalSupply()
        {
            return 32313908246384776;
        }
    }
}
