using System;
using System.Collections.Generic;
using System.Text;

namespace _2K2SNP.Repositories
{
    interface IRepository
    {
        void Add();
        void Remove(int ind);
    }
}
