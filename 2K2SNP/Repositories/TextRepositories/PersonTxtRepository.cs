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
    public abstract class PersonTxtRepository : TxtRepository
    {
        public PersonTxtRepository(string src) : base(src)
        {
            param_amount = 5;
            ReadFromFile();
        } 

        protected override void Sync() => File.WriteAllLines(src, data.Select(x => x.ToString()).ToArray());

        protected override void ReadFromFile()
        {
            string line = string.Empty;
            bool is_sync = sync;


            using (StreamReader file = new StreamReader(src))
            {
                sync = false;
                while (true)
                {
                    //Collect parameters
                    List<string> paramsList = new List<string>();
                    for (int i = 0; i < param_amount; i++)
                        if (!string.IsNullOrEmpty(line = file.ReadLine()))
                            paramsList.Add(line.Split(" ").Last());
                        else break;
                    if (string.IsNullOrEmpty(line))
                        break;

                    Add(CreateSpecialUnit(paramsList));
                }
                sync = is_sync;
            }
        }

        protected abstract Unit CreateSpecialUnit(List<string> paramsList);
    }
}
