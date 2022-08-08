﻿using StrategyDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public  class ExchangeUser
    {
        ISetUserFee _setUserFee = null;
        public ExchangeUser(ISetUserFee _isuf)
        {
            _setUserFee = _isuf;
        }
        public string SetUserMakerFee(string user)
        {
            return _setUserFee.SetUserMakerFee(user);
        }
        public string SetUserTakerFee(string user)
        {
            return _setUserFee.SetUserTakerFee(user);
        }
    }
}
