using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Classes
{
    public class Holo : IErc20
    {
        private readonly string _name;
        public Holo()
        {
            this._name = "HoloToken";
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
            return "0x0fc4ea7046379b89b7fb3e6914bb1962f8473984";
        }

        public string symbol()
        {
            return "HOT";
        }

        public decimal totalSupply()
        {
            return 177619433541.141312344380335741m;
        }
    }
}
