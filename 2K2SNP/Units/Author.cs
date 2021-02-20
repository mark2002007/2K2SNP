using System;

namespace _2K2SNP.Units
{
    public class Author : Person
    {
        public int yob { get; private set; }
        public int yod { get; private set; }

        public Author(string fName = "", string mName = "", string lName = "", int yob = 0, int yod = 0)
            : base(fName, mName, lName)
        {
            this.yob = yob;
            this.yod = yod;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nYear of Birth : {yob}\nYear of Death : {yod}";
        }
    }
}