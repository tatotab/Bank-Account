using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class SavingAcc
    {
        protected string accNumber { get; set; }
        protected float interestRate { get; set; }
        protected double accBalance{ get; set; }
        public SavingAcc(string accNum, float intRate, double accBal)
        {
            accNumber = accNum;
            interestRate = intRate;
            accBalance= accBal;
        }

        public double getBalance()
        {
            return accBalance;
        }
    }
}
