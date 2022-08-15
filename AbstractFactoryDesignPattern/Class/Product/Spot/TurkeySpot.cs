using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Class.Product.Spot
{
    internal class TurkeySpot : Exchange
    {
        public override void ShowProperty()
        {
            Console.WriteLine("Turkey borsası spot işlemleri yapıldı.");
        }
    }
}
