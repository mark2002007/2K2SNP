using System;
using System.Linq;

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
            this.pub_year = pub_year;
            this.pages = pages < 0 ? 0 : pages;
            this.ISBN = (ISBN??="0").Length <= 13? 
                ISBN + new string('0', 13 - ISBN.Length) : 
                string.Join("",ISBN.Take(13));
        }

        public override string ToString() => 
            $"Author : {author?.fName} {author?.mName} {author?.lName}\nTitle : {title}\nPublication Year : {pub_year}\nNumber of Pages : {pages}\nISBN : {ISBN}";

        public override string ToCSV() => $"{author?.fName},{author?.mName},{author?.lName},{title},{pub_year},{pages},{ISBN}";
    }
}