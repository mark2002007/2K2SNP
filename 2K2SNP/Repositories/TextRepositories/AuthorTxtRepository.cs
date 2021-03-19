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
    public class AuthorTxtRepository : PersonTxtRepository
    {
        public AuthorTxtRepository(string src) : base(src) {}
        public int IndexByFullName(Person u)
        {
            for (int i = 0; i < data.Count; i++)
                if (((Person)data[i]).fName == u.fName &&
                    ((Person)data[i]).mName == u.mName &&
                    ((Person)data[i]).lName == u.lName
                )
                    return i;
            return -1;
        }
        protected override Unit CreateSpecialUnit(List<string> paramsList) => new Author(
            paramsList[0],
            paramsList[1],
            paramsList[2],
            int.Parse(paramsList[3]),
            int.Parse(paramsList[4])
        );
    }
}
