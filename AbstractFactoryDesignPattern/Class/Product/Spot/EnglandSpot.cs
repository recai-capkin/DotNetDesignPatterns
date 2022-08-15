using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Class.Product
{
    internal class EnglandSpot : Exchange
    {
        public override void ShowProperty()
        {
            Console.WriteLine("England borsası spot işlemleri yapıldı.");
        }
    }
}
