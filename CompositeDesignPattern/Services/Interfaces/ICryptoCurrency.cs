using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Services.Interfaces
{
    public interface ICryptoCurrency
    {
        string Name { get; }
        decimal TotalValue { get; }
        void DisplayInfo();
    }
}
