using System;

namespace _2K2SNP.Units
{
    public class Customer : Person
    {
        public int balance { get; private set; }
        public int purchases { get; private set; }

        public Customer(string fName = "", string mName = "", string lName = "", int balance = 0, int purchases = 0)
            : base(fName, mName, lName)
        {
            this.balance = balance;
            this.purchases = purchases;
        }

        public override string ToString()
        {
            return base.ToString() + '\n' + $"Balance : {balance}\nPurchases : {purchases}";
        }
    }
}