using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading;
using _2K2SNP.Units;

namespace _2K2SNP.Repositories
{
    public class Repository : IRepository
    {
        public List<Unit> data { get; protected set; }

        public Repository() => data = new List<Unit>();

        public virtual List<Unit> GetData() => data;

        public virtual void Add(Unit elem) 
        {
            if(elem != null)
                data.Add(elem);
        }

        public virtual void Remove(int ind)
        {
            if(ind < data.Count)
                data.RemoveAt(ind < 0? data.Count + ind : ind);
        }
        public virtual void Refresh() {}
        public override string ToString()
        {
            string str = string.Empty;
            for (int i = 0; i < data.Count; i++)
                str += $"{i + 1}\n{data[i]}\n";
            return str;
        }

        public Unit this[int index]
        {
            get => data[index];
            set => data[index] = value;
        }


    }
}
