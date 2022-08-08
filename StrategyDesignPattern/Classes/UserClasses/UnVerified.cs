﻿using StrategyDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Classes.UserClasses
{
    public class UnVerified : ISetUserFee
    {

        public string SetUserMakerFee(string user)
        {
            return user + " adlı kullanıcının maker fee oranı 0.10m";
        }

        public string SetUserTakerFee(string user)
        {
            return user + " adlı kullanıcının taker fee oranı 0.10m";
        }
    }
}
