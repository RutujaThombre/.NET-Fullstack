﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_6
{
    class HDFC : Account
    {
        public HDFC(double an, string cname, double bal) : base(an, cname, bal)
        { }
        public bool ZeroBalance(double amount)
        {
            return false;
        }
        public bool UnderBalance(double amount)
        {
            if (account_balance <= 1000 || account_balance - amount <= 0)
            {
                Console.WriteLine("Transaction cannot be continued below specified limit of Rs.- 1000");
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void Deposit(int v)
        {
            throw new NotImplementedException();
        }

        internal void Withdraw(int v, Func<double, bool> underBalance, Func<double, bool> zeroBalance)
        {
            throw new NotImplementedException();
        }
    }
}
