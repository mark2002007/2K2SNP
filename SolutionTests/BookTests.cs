using System;
using System.Diagnostics.CodeAnalysis;
using _2K2SNP.Units;
using Xunit;

namespace SolutionTests
{
    public class BookTests
    {
        [Fact]
        public void Ctor_ParseNullToParameters_NoException()
        {
            //arrange\act
            Book b = new Book(null,null,0,0,null);
        }

        [Fact]
        public void Ctor_PagesIsNegative_PagesEquals0()
        {
            //arrange
            Author a = null;
            string title = null;
            int pub_year = 0;
            int pages = -1;
            string ISBN = "1231231231231";
            //act
            Book b = new Book(a, title, pub_year, pages, ISBN);
            //assert
            Assert.Equal(0, b.pages);
        }

        [Fact]
        public void Ctor_IncorrectISBNLenghtLess_AutoFormatedISBN()
        {
            //arrange
            Author a = null;
            string title = null;
            int pub_year = 0;
            int pages = 0;
            string ISBN = "1";
            //act
            Book b = new Book(a, title, pub_year, pages, ISBN);
            //assert
            Assert.Equal("1000000000000", b.ISBN);
        }

        [Fact]
        public void Ctor_IncorrectISBNLenghtGreater_AutoFormatedISBN()
        {
            //arrange
            Author a = null;
            string title = null;
            int pub_year = 0;
            int pages = 0;
            string ISBN = "123123123123123";
            //act
            Book b = new Book(a, title, pub_year, pages, ISBN);
            //assert
            Assert.Equal("1231231231231", b.ISBN);
        }

        [Fact]
        public void ToString_StandartParameters_CorrectInStringRepresentation()
        {
            //arrange
            Author a = null;
            string title = null;
            int pub_year = 0;
            int pages = 0;
            string ISBN = "1231231231231";
            //act
            Book b = new Book(a, title, pub_year, pages, ISBN);
            //assert
            var r = b.ToString();
            Assert.Equal($"Author : {a?.fName} {a?.mName} {a?.lName}\nTitle : {title}\nPublication Year : {pub_year}\nNumber of Pages : {pages}\nISBN : {ISBN}", r);
        }

        [Fact]
        public void ToCSV_StandartParameters_CorrectCSVRepresentation()
        {
            //arrange
            Author a = null;
            string title = null;
            int pub_year = 0;
            int pages = 0;
            string ISBN = "1231231231231";
            //act
            Book b = new Book(a, title, pub_year, pages, ISBN);
            //assert
            Assert.Equal($"{a?.fName},{a?.mName},{a?.lName},{title},{pub_year},{pages},{ISBN}", b.ToCSV());
        }
    }
}