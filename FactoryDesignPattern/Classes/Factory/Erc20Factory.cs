using FactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Classes
{
    public class Erc20Factory
    {
        public static IErc20 getToken(string token)
        {
            IErc20 ec20 = null;
            if (token.ToLower() == "holo")
            {
                ec20 = new Holo();
            }
            else if (token.ToLower() == "dent")
            {
                ec20= new Dent();
            }
            else if (token.ToLower() == "tether")
            {
                ec20= new Tether();
            }
            return ec20;
        }
    }
}
