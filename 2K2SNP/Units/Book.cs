using System;

namespace _2K2SNP.Units
{
    public class Book : Unit
    {
        public Author author { get; private set; }
        public string title { get; private set; }
        public int pub_year { get; private set; }
        public int pages { get; private set; }
        public string ISBN { get; private set; }

        public Book(Author author = null, string title = "None", int pub_year = 0, int pages = 0, string ISBN = "999999999999X")
        {
            this.title = title;
            this.author = author;
            //if (pub_year > 2021) throw new Exception("PubYear_ERROR");
            this.pub_year = pub_year;
            //if (pages < 0) throw new Exception("PagesCount_ERROR");
            this.pages = pages;
            //if (ISBN.Length != 13) throw new Exception("ISBN_ERROR");
            this.ISBN = ISBN;
        }

        public override string ToString()
        {
            return $"Author : {author.fName} {author.mName} {author.lName}\nTitle : {title}\nPublication Year : {pub_year}\nNumber of Pages : {pages}\nISBN : {ISBN}";
        }
    }
}