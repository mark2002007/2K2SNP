using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using _2K2SNP.Units;

namespace _2K2SNP.Repositories.TextRepositories
{
    public class BookTxtRepository : TxtRepository
    {
        protected AuthorTxtRepository related_rep { get; set; }

        public BookTxtRepository(string src, AuthorTxtRepository related_rep, bool sync = true)  : base(src, sync)
        {
            param_amount = 5;
            this.related_rep = related_rep;
            ReadFromFile();
        }

        protected override Unit CreateSpecialUnit(string[] paramsList) =>
            new Book(
                related_rep.GetAuthorByFullName(paramsList[0],paramsList[1],paramsList[2]),
                paramsList[3],
                int.Parse(paramsList[4]),
                int.Parse(paramsList[5]),
                paramsList[6]
            );
    }
}
