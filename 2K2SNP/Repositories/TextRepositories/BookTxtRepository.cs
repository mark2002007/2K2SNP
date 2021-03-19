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

        protected override void Sync()
        {
            string[] sarr = ToString().Split("\n");
                for (int i = 0; i < sarr.Length; i++)
                {
                    string[] sub_sarr = sarr[i].Split(" ");
                    if (sub_sarr.First() == "Author")
                    {
                        Person tauth = new Author(sub_sarr[sub_sarr.Length - 3], sub_sarr[sub_sarr.Length - 2], sub_sarr[sub_sarr.Length - 1]);
                        int auth_num = related_rep.IndexByFullName(tauth);
                        sarr[i] = "Author : " + (auth_num + 1);
                    }
                }
                File.WriteAllLines(src, sarr);
        }

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

                    Add(new Book(
                        (Author) related_rep.data[int.Parse(paramsList[0]) - 1],
                        paramsList[1],
                        int.Parse(paramsList[2]),
                        int.Parse(paramsList[3]),
                        paramsList[4]
                    ));
                }
                sync = is_sync;
            }
        }
    }
}
