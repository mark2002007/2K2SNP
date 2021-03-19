using _2K2SNP.Repositories;

namespace _2K2SNP.Factories
{
    public interface IFactory
    {
        public IRepository createAuthorRepository();

        public IRepository createBookRepository(IRepository related_rep = null);

        public IRepository createCustomerRepository();

        public IRepository createEmployeeRepository();
    }
}