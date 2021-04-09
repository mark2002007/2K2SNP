using System;

namespace _2K2SNP.Units
{
    public class Person : Unit
    {
        public string fName { get; protected set; }
        public string mName { get; protected set; }
        public string lName { get; protected set; }

        public Person(string fName = "", string mName = "", string lName = "")
        {
            this.fName = fName;
            this.mName = mName;
            this.lName = lName;
        }

        public override string ToString() => $"First Name : {fName}\nMiddle Name : {mName}\nLast Name : {lName}";

        public override string ToCSV() => $"{fName},{mName},{lName}";
    }
}