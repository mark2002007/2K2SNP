using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using _2K2SNP.Units;

namespace _2K2SNP.Repositories
{
    public class AuthorTxtRepository : TxtRepository
    {
        public AuthorTxtRepository(string src) : base(src) => ReadFromFile();

        public Author GetAuthorByFullName(string fName, string mName, string lName)
        {
            for (int i = 0; i < data.Count; i++)
                if (((Person)data[i]).fName == fName &&
                    ((Person)data[i]).mName == mName &&
                    ((Person)data[i]).lName == lName)
                    return (Author)data[i];
            return null;
        }

        protected override Unit CreateSpecialUnit(string[] paramsList) =>
            new Author(
                paramsList[0],
                paramsList[1],
                paramsList[2],
                int.Parse(paramsList[3]),
                int.Parse(paramsList[4])
            );
    }
}
