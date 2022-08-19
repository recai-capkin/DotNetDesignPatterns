using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Classes.Abstract
{
    abstract class MineableCryptoCurrency
    {
        public string name;
        public abstract void Mine();
    }
}
