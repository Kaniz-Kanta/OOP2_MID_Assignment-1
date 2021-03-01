using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static int accountNumber = 1000;
        static void Main(string[] args)
        {

            /*Address address1 = new Address("45", "10", "Dhaka", "Bangladesh");
            Account account1 = new Account(1001,"Shakib",2000,address1);
            account1.ShowAccountInformation();
            Console.WriteLine();
            account1.Deposite(220.5);
            Console.WriteLine();
            account1.ShowAccountInformation();
            Console.WriteLine();
            account1.Withdraw(100);
            Console.WriteLine();
            account1.ShowAccountInformation();*/
            Bank ourBank = new Bank("Developer's bank", 5);
            ourBank.AddAccount(new Account(accountNumber++, "Shakib", 2000, new Address("45", "10", "Dhaka", "Bangladesh")));
            // ourBank.PrintAccountDetails();

            ourBank.AddAccount(new Account(accountNumber++, "Rahman", 1500, new Address("54", "17", "Rajshahi", "Bangladesh")));
            ourBank.PrintAccountDetails();
            ourBank.Check(1);
        }
    }
}
