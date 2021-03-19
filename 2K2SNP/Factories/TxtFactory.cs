using System;
using System.Collections.Generic;
using System.Text;
using _2K2SNP.Repositories;
using _2K2SNP.Repositories.TextRepositories;

namespace _2K2SNP.Factories
{
    public class TxtFactory : IFactory
    {
        public IRepository createAuthorRepository() => new AuthorTxtRepository(@"C:\Programs\MyPrograms\C#\2K2SNP\2K2SNP\Data\Authors.txt");
        public IRepository createBookRepository(IRepository related_rep) => new BookTxtRepository(@"C:\Programs\MyPrograms\C#\2K2SNP\2K2SNP\Data\Books.txt", (AuthorTxtRepository)related_rep);
        public IRepository createCustomerRepository() => new CustomerTxtRepository(@"C:\Programs\MyPrograms\C#\2K2SNP\2K2SNP\Data\Customers.txt");
        public IRepository createEmployeeRepository() => new EmployeeTxtRepository(@"C:\Programs\MyPrograms\C#\2K2SNP\2K2SNP\Data\Employees.txt");
    }
}
