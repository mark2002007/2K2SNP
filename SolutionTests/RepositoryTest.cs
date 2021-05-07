using System;
using System.Collections.Generic;
using System.Linq;
using _2K2SNP.Repositories;
using _2K2SNP.Units;
using Xunit;

namespace SolutionTests
{
    public class RepositoryTests
    {
        [Fact]
        public void Add_Null_EmptyList()
        {
            //arrange
            Repository rep = new Repository();
            Author a = null;
            //act
            rep.Add(a);
            //assert
            Assert.Equal(new List<Unit>(), rep.GetData());
        }

        [Fact]
        public void Remove_NegativeIndex_RemoveBehind()
        {
            //arrange
            Repository rep = new Repository();
            Author a1 = new Author("A");
            Author a2 = new Author("B");
            int ind = -1;
            //act
            rep.Add(a1);
            rep.Add(a2);
            rep.Remove(ind);
            //assert
            var r = (rep.GetData().Last() as Author).fName;
            Assert.Equal(a1.fName, r);
        }

        [Fact]
        public void Remove_ExceedIndex_Nothing()
        {
            //arrange
            Repository rep = new Repository();
            Author a1 = new Author("A");
            Author a2 = new Author("B");
            int ind = 2;
            //act
            rep.Add(a1);
            rep.Add(a2);
            rep.Remove(ind);
            //assert
            Assert.Equal(a2.fName, (rep.GetData().Last() as Author).fName);
        }

        [Fact]
        public void ToString_StandartParameters_CorrectInStringRepresentation()
        {
            //arrange
            Repository rep = new Repository();
            Author a1 = new Author("A");
            Author a2 = new Author("B");
            //act
            rep.Add(a1);
            rep.Add(a2);
            //assert
            Assert.Equal($"1\n{a1}\n" + $"{2}\n{a2}\n",rep.ToString());
        }

    }
}
