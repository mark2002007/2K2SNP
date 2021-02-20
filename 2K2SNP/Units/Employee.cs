using System;

namespace _2K2SNP.Units
{
    public class Employee : Person
    {
        public int salary { get; private set; }
        public int rank { get; private set; }

        public Employee(string fName = "", string mName = "", string lName = "", int salary = 0, int rank = 0)
            : base(fName, mName, lName)
        {
            this.salary = salary;
            this.rank = rank;
        }

        public override string ToString()
        {
            return base.ToString() + '\n' + $"Salary : {salary}\nRank : {rank}";
        }
    }
}