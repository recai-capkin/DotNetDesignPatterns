using AbstractFactoryDesignPattern.Class.AbstractFactory;
using AbstractFactoryDesignPattern.Class.Product;
using AbstractFactoryDesignPattern.Class.Product.Earn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Class.ConcreteFactory
{
    public class EnglandExchangeFactory : ExchangeFactory
    {
        public override Exchange CreateEarn()
        {
            return new EnglandEarn();
        }

        public override Exchange CreateSpot()
        {
            return new EnglandSpot();
        }
    }
}
