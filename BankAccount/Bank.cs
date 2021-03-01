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
                    myBank[i] = myBank[i + 1];
                    break;
                }
                else
                {
                    Console.WriteLine("Account Not Found!!!");
                }
            }
        }
        //object[] optional = new object[] { 200, 1001 };
        public void Transaction(int transactionType, params object[] optional)
        {
            if (transactionType == 1)
            {
                Account.Deposite(optional[]);
            }
            else if (transactionType == 2)
            {
                Account.Withdraw(optional[]);
            }
            else if(transactionType == 3)
            {
                Account.Transfer(optional[]);
            }
            else
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
