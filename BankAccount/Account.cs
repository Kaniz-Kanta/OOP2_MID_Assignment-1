using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
     class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;//1-1 Relation


        public int getAccountNumber()
        {
            return accountNumber;
        }

        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public void Deposite(double amount)
        {
            Console.WriteLine("Enter the Account Number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int i = 0; i <myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].getAccountNumber() == accNo)
                {
                    Console.WriteLine("Account Found!!!!");
                    myBank[i].Balance = myBank[i].Balance + amount;
                    Console.WriteLine("Your Current Balance Is: " + myBank[i].Balance);
                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;

                }

            }
            if (flag == 1)
                Console.WriteLine("Account Not Found!!!!");
        }
        public void Withdraw(double amount)
        {
            Console.WriteLine("Enter the Account Number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].getAccountNumber() == accNo)
                {
                    Console.WriteLine("Account Found!!!!");
                    myBank[i].Balance = myBank[i].Balance - amount;
                    Console.WriteLine("Your Current Balance Is: " + myBank[i].Balance);
                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;

                }

            }
            if (flag == 1)
                Console.WriteLine("Account Not Found!!!!");
        }
        public void Transfer(Account receiver, double amount)
        {
            Console.WriteLine("Enter the Sender Account Number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
                for (int j = 0; i < myBank.Length; j++)
                {
                    if (myBank[i].getAccountNumber() == null && myBank[j]==null)
                    {
                        continue;
                    }
                    else if (myBank[i].getAccountNumber() == accNo && myBank[j] == receiver)
                    {
                        Console.WriteLine("Account Found!!!!");
                        myBank[i].Balance.Withdraw(amount);
                        myBank[j].Balance.Deposite(amount);
                        Console.WriteLine("Money Transfered Succesfully!!!!!");
                        flag = 0;
                        break;
                    }
                    else
                    {
                        flag = 1;

                    }

                }
                if (flag == 1)
                    Console.WriteLine("Account Not Found!!!!");

            }
        }

        public Account(int accountNumber, string accountName, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }

        public void ShowAccountInformation()
        {
            
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
            this.address.PrintAddress();
        }
        
       
    }
}

