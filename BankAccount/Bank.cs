using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;//1-* Relation
        public Bank(string name, int size)
        {
            this.bankName = name;
            myBank = new Account[size];
        }
        public string Name
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }
        public Account[] MyBank
        {
            set { this.myBank = value; }
            get { return this.myBank; }
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }
        public void DeleteAccount(Account accountNumber)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = myBank[i + 1];
                    break;
                }
                else if (myBank[i] == accountNumber)
                {
                    myBank[i] = null;
                    myBank[i] = myBank[i + 1];
                    break;
                }
                else
                {
                    Console.WriteLine("Account Not Found!!!");
                }
            }
        }

        public void Transaction(int transactionType, [Optional] double amount, [Optional] Account receiver)
        {
            Console.WriteLine("Enter a Account Number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (transactionType == 1 && myBank[i].GetAccountNumber() == accountNumber)
                {
                    myBank[i].Deposite(amount);
                    check = true;
                    break;
                }
                else if (transactionType == 2 && myBank[i].GetAccountNumber() == accountNumber)
                {
                    myBank[i].Withdraw(amount);
                    check = true;
                    break;
                }
                else if (transactionType == 3 && myBank[i].GetAccountNumber() == accountNumber)
                {
                    myBank[i].Transfer(receiver, amount);
                    check = true;
                    break;
                }

            }
            if (check == false)
            {
                Console.WriteLine("You Choose a Wrong Number!!!! ");
            }
        } 
        public void PrintAccountDetails()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].ShowAccountInformation();
            }
        }
    }
}
