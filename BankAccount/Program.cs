using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static int GanerateAccountNumber(int i)
        {
            int start = 1000;
            int accountNumber = start + i;
            return accountNumber;
        }
        static void Main(string[] args)
        {
            bool limit = true;
            while (limit)
            {
                Console.WriteLine("How many accounts do you want to create? \n");
               int size = Convert.ToInt32(Console.ReadLine());
               Bank ourBank = new Bank("Developer's bank", size);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("\nAccount " + (i + 1) + "------");
                Console.WriteLine("Name: ");
                string accountName = Console.ReadLine();
                Console.WriteLine("Balance: ");
                double balance = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("House no: ");
                string houseNo = Console.ReadLine();
                Console.WriteLine("Road no: ");
                string roadNo = Console.ReadLine();
                Console.WriteLine("City: ");
                string city = Console.ReadLine();
                Console.WriteLine("Country: ");
                string country = Console.ReadLine();

                ourBank.AddAccount(new Account(GanerateAccountNumber(i), accountName, balance, new Address(houseNo, roadNo, city, country)));

            }
            ourBank.PrintAccountDetails();
            ourBank.Transaction(2, 100);
            ourBank.PrintAccountDetails();
                Console.WriteLine("\n Press 0 for close this application \n");
                int stop = Convert.ToInt32(Console.ReadLine());
                if (stop == 0)
                {
                    limit = false;
                }
            }
        }
    }
}
