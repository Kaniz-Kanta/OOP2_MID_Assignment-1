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
                    myBank[i] = myBank[i+1];
                    break;
                }
                else if(myBank[i] == accountNumber)
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
        /*public void Transaction(int transactionType, object[] optional)
        {
            if (transactionType == 1)
            {
                BankAccount.Account.Deposite(optional[]);
                break;
            }
            else if (transactionType == 2)
            {
                BankAccount.Account.Withdraw(optional[]);
                break;
            }
            else if(transactionType == 3)
            {
                BankAccount.Account.Transfer(optional[]);
                break;
            }
            else
            {
                Console.WriteLine("You Choose a Wrong Number!!!! ");
            }
        }*/
        public  void Check(int acc)
        {
            bool count = false;
            for (int i = 0; i < myBank.Length - 1; i++)
            {
                if (myBank[i] != null)
                {
                    if (myBank[i].getAccountNumber() == acc)
                    {
                        Console.WriteLine(acc + " Account number found ");
                        count = true;
                    }
                }
            }
            if (count == false)
            {
                Console.WriteLine(acc + " account number doesnt found !!");
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
