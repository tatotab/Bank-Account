using System;
using System.Collections.Generic;
using System.Linq;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            DateTime maturity;
            string accNumber;
            float interest;
            double balance, amount;
            List<CD_Account> AccountList = new List<CD_Account>();
            for(int i =0; i<3; i++)
            {
                Console.WriteLine("Enter Account Number, Interest Rate and Balance one at a time: ");
                accNumber = Console.ReadLine();
                interest = float.Parse(Console.ReadLine());
                balance = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Maturity Date(Year, Month, Day):");
                DateTime.TryParse(Console.ReadLine(), out maturity);

                AccountList.Add(new CD_Account(accNumber, interest, balance, maturity));
            }
            var orderedList = from element in AccountList //sorts list by balance
                              orderby element.getBalance()
                              select element;
            orderedList.Reverse(); //reverse list so it will be decreaasing order
            foreach (var Account in orderedList) //prints contents
            {
                Account.toString();
                Console.WriteLine("If you wish to Deposit or Withdraw write operation name and amount on next line,\n otherwise press any key");
                switch (Console.ReadLine())
                {
                    case "Deposit":
                        amount = double.Parse(Console.ReadLine());
                        Account.Deposit(amount);
                        break;

                    case "Withdraw":
                        amount = double.Parse(Console.ReadLine());
                        if (Account.CheckBalance(amount))
                        {
                            Console.WriteLine("Requested Amount is more than Balance that is available, please request less");
                            amount = double.Parse(Console.ReadLine());
                        }
                        Account.Withdraw(amount);
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
