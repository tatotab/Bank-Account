using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class CD_Account : SavingAcc
    {
        private DateTime maturityDate { get; set; }
        public CD_Account(string accNum, float intRate, double accBal, DateTime date)
            :base(accNum, intRate, accBal)
        {
            maturityDate =date;
        }
        public void Deposit(double amount)
        {
            accBalance += amount;
            Console.WriteLine("Requested Deposit: ${0}\n" +
                                      "New Total: ${1}", amount, accBalance);
        }
        public void Withdraw(double amount)
        {
            accBalance -= amount;
            Console.WriteLine("Requested Withrdaw: ${0}\n" +
                              "Balance on Account: ${1}", amount, accBalance);
        }
        public void toString()
        {
            Console.WriteLine("\nACCOUNT INFORMATION");
            Console.WriteLine(" Account Number:  {0}", accNumber);
            Console.WriteLine("Account Balance:  ${0}", accBalance);
            Console.WriteLine("  Interest Rate:  {0}%", interestRate);
            Console.WriteLine("  Maturity Date   {0}", maturityDate.ToShortDateString());
            Console.WriteLine();
        }
        public bool CheckBalance(double amount)
        {
            return amount > accBalance;
        }
    }
}
