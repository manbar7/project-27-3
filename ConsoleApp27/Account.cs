using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Account
    {
        private static int numberOfAcc = 0;
        private readonly int accountNumber;
        private readonly Customer accountOwner;
        private int maxMinusAllowed;
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }
        public int Balance { get; private set; }
        public Customer AccountOwner
        {
            get
            {
                return accountOwner;
            }
        }
        public int MaxMinusAllowed
        {
            get
            {
                return maxMinusAllowed;
            }

        }

        public Account(Customer customer, int montlyIncome)
        {
            this.accountOwner = customer;
            this.maxMinusAllowed = montlyIncome * -3;
            numberOfAcc++;
            this.accountNumber = numberOfAcc;
            this.Balance = 0;
        }
        public static bool operator ==(Account a1,Account a2)
        {
            if (a1 == a2)
                return true;
            else
                return false;
        }

        public static bool operator !=(Account a1, Account a2)
        {
            if (a1 != a2)
                return false;
            else
                return true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Account)
            {
                Account a = obj as Account;
                return this == a;
            }
            return false;
        }

        public static Account operator +(Account a1, Account a2)
        {
            int NewBalance = 0;
            if (a1.accountOwner != a2.accountOwner)
            {
                throw new NotSameCustomerException();
            }
            else
            {
                if (a1.maxMinusAllowed < a2.maxMinusAllowed)
                    NewBalance = a1.maxMinusAllowed / -3;
                else
                    NewBalance = a2.maxMinusAllowed /-3;
                Account a3 = new Account(a1.accountOwner, NewBalance);
                a3.Balance = a1.Balance + a2.Balance;              
                a3.maxMinusAllowed = a1.maxMinusAllowed;
                return a3;
            }
            

        }

    }
}
