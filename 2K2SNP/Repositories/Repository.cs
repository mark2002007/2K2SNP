using System;
using System.Collections.Generic;
using _2K2SNP.Units;

namespace _2K2SNP.Repositories
{
    public class Repository
    {
        public List<Unit> data { get; protected set; }
        public bool sync { get; protected set; }

        public Repository(bool sync = false)
        {
            data = new List<Unit>();
            this.sync = sync;
        }

        public void Add(Unit elem)
        {
            data.Add(elem);
        }

        public void Remove(int ind)
        {
            data.RemoveAt(ind);
        }

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
