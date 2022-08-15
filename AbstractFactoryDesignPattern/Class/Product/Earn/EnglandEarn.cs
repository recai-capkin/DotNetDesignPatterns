using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Class.Product.Earn
{
    public class EnglandEarn : Exchange
    {
        public override void ShowProperty()
        {
            Console.WriteLine("England Kazan sistemi işlemleri yapıldı.");
        }
    }
}
