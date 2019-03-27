using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Account
    {
        private static int NumberOfAcc;
        private readonly int accountNumber;
        private readonly Customer accountOwner;
        private int maxMinusAllowed;
        public int AccountNumber { get; }
        public int Balance { get; private set; }
        public Customer AccountOwner { get;}
        public int MaxMinusAllowed { get;}

        public Account(int accountNum, Customer c1, int MontlyIncome)
        {
            accountNumber++;
            AccountNumber = accountNumber;
            MaxMinusAllowed = MontlyIncome * 3;
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
            if (obj is Customer)
            {
                Account a = obj as Account;
                return this == a;
            }
            return false;
        }

        public static bool operator +(Account a1,Account a2)
        {

        }
    }
}
