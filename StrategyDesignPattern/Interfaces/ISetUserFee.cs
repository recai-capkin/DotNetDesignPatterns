using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Interfaces
{
    public interface ISetUserFee
    {
        string SetUserMakerFee(string user);
        string SetUserTakerFee(string user);
    }
}
