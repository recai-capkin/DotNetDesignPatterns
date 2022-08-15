using AbstractFactoryDesignPattern.Class.AbstractFactory;
using AbstractFactoryDesignPattern.Class.Product.Earn;
using AbstractFactoryDesignPattern.Class.Product.Spot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Class.ConcreteFactory
{
    public class TurkeyExchangeFactory : ExchangeFactory
    {
        public override Exchange CreateEarn()
        {
            return new TurkeyEarn();
        }

        public override Exchange CreateSpot()
        {
            return new TurkeySpot();
        }
    }
}
