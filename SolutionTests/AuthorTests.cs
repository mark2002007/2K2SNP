using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2K2SNP.Units;
using Xunit;

namespace SolutionTests
{
    public class AuthorTests
    {
        [Fact]
        public void Ctor_ParseNullToParameters_NoException()
        {
            //arrange\act
            Author a = new Author(null, null, null, 0, 0);
        }

        [Fact]
        public void Ctor_YOBIsGreaterThenYOD_TheyAreEquals()
        {
            //arrange
            int yearOfBirth = 1990;
            int yearOfDeath = 1800;
            //act
            Author a = new Author("1", "2", "3", yearOfBirth, yearOfDeath); //Year of birth is greater than death
            //assert
            Assert.Equal(0, a.yod);
        }

        [Fact]
        public void ToString_StandartParameters_CorrectInStringRepresentation()
        {
            //arrange
            string fName = "F";
            string mName = "M";
            string lName = "L";
            int yearOfBirth = 1990;
            int yearOfDeath = 0;
            //act
            Author a = new Author(fName, mName, lName, yearOfBirth, yearOfDeath); //Year of birth is greater than death
            //assert
            Assert.Equal($"First Name : {fName}\nMiddle Name : {mName}\nLast Name : {lName}\nYear of Birth : {yearOfBirth}\nYear of Death : {yearOfDeath}", a.ToString());
        }

        [Fact]
        public void ToCSV_StandartParameters_CorrectCSVRepresentation()
        {
            //arrange
            string fName = "F";
            string mName = "M";
            string lName = "L";
            int yearOfBirth = 1990;
            int yearOfDeath = 0;
            //act
            Author a = new Author(fName, mName, lName, yearOfBirth, yearOfDeath); //Year of birth is greater than death
            //assert
            Assert.Equal($"{fName},{mName},{lName},{yearOfBirth},{yearOfDeath}", a.ToCSV());
        }

    }
}
