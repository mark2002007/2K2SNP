using System;
using System.Collections.Generic;
using System.Text;
using _2K2SNP.Repositories;

namespace _2K2SNP.Factories
{
    public class MemoryFactory : IFactory
    {
        private IRepository createRepository() => new Repository();
        public IRepository createAuthorRepository() => createRepository();
        public IRepository createBookRepository(IRepository related_rep = null) => createRepository();
        public IRepository createCustomerRepository() => createRepository();
        public IRepository createEmployeeRepository() => createRepository();
    }
}
