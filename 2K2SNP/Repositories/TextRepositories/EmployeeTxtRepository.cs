﻿using System;
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
    public class EmployeeTxtRepository : PersonTxtRepository
    {
        public EmployeeTxtRepository(string src) : base(src) { }
        protected override Unit CreateSpecialUnit(List<string> paramsList) => new Employee(
            paramsList[0],
            paramsList[1],
            paramsList[2],
            int.Parse(paramsList[3]),
            int.Parse(paramsList[4])
        );
    }
}
