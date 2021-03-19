using System;
using System.Collections.Generic;
using System.Text;
using _2K2SNP.Units;

namespace _2K2SNP.Repositories
{
    public interface IRepository
    {
        void Add(Unit elem);
        void Remove(int ind);
        public Unit this[int index] { get; set; }
    }
}
