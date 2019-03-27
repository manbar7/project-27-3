using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Customer
    {
        private static int NumberOfCust;
        private readonly int customerID;
        private readonly int customerNumber;
        public string Name { get; private set; }
        public int PhNumber { get; private set; }
        public int CustomerID { get; }
        public int CustomerNumber { get; }

        public Customer(string name, int phone, int id)
        {
            this.Name = name;
            this.PhNumber = phone;
            this.CustomerID = id;
            customerNumber++;
            CustomerNumber = customerNumber;

        }

        public static bool operator ==(Customer c1,Customer c2)
        {
            if (c1 == c2)
                return true;
            else
                return false;
        }

        public static bool operator !=(Customer c1,Customer c2)
        {
            if (c1 != c2)
                return false;
            else
                return true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Customer)
            {
                Customer c = obj as Customer;
                return this == c;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.CustomerNumber;
        }

        public override string ToString()
        {
            return ($"Name:{Name},ID Number:{CustomerID},Customer Number:{CustomerNumber},Phone Number:{PhNumber}");
        }
    }
}
