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

        public Account(int accountNumber, string accountName, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        public int GetAccountNumber()
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
        public void Withdraw(double amount)
        {
            if (this.balance >= amount)
            {
                this.balance = this.balance - amount;
            }
            else
            {
                Console.WriteLine("Withdraw not possible!!");
            }
        }
        public void Deposite(double amount)
        {
            this.balance = this.balance + amount;
        }
        public void Transfer(Account receiver, double amount)
        {
            receiver.Deposite(amount);
            this.Withdraw(amount);
        }
        public void ShowAccountInformation()
        {

            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}\nAddress:{3}",
                accountNumber, this.accountName, this.balance, this.address.GetAddress());

        }



    }
}
