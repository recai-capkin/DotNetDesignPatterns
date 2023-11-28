using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Prototypes.Services.Interfaces
{
    public interface ICryptoCurrencyPrototype
    {
        ICryptoCurrencyPrototype Clone();
    }
}
