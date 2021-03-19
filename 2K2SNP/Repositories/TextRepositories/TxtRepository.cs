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
    public abstract class TxtRepository : Repository
    {
        protected int param_amount { get; set; } //Number of parameters
        protected string src { get; set; } //Path to txt file
        protected bool sync { get; set; }
        public TxtRepository(string src = null, bool sync = true)
        {
            this.src = src;
            this.sync = sync;
        }

        public override void Add(Unit elem)
        {
            data.Add(elem);
            if(sync)
                Sync();
        }

        public override void Remove(int ind)
        {
            data.RemoveAt(ind);
            if (sync)
                Sync();
        }
        
        protected abstract void Sync();

        protected abstract void ReadFromFile();
    }
}
