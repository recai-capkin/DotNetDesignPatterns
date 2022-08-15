using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Class.AbstractFactory
{
    public abstract class ExchangeFactory
    {
        public abstract Exchange CreateSpot();
        public abstract Exchange CreateEarn();

        //Bazı borsalarda bu futures işlemler engellenebiliyor
        public virtual Exchange CreateFuturesMarket() 
        {
            return null; 
        }
    }
}
