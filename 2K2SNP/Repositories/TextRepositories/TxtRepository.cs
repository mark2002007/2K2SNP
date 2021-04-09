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

        public override List<Unit> GetData()
        {
            ReadFromFile();
            return base.GetData();
        }

        public override void Refresh() => ReadFromFile();

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

        protected void Sync() => File.WriteAllLines(src, data.Select(x => x.ToCSV()).ToArray());

        public void ReadFromFile()
        {
            data = new List<Unit>();
            string line = string.Empty;
            bool is_sync = sync;
            using (StreamReader file = new StreamReader(src))
            {
                sync = false;
                while (true)
                {
                    line = file.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                        Add(CreateSpecialUnit(line.Split(",")));
                    else
                        break;
                }
                sync = is_sync;
            }
        }

        protected abstract Unit CreateSpecialUnit(string[] paramsList);
    }
}
