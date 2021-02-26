using _2K2SNP.Menu;
namespace _2K2SNP.Commands
{
    public class AddAuthorCommand : Command
    {
        private IMenu receiver { get; set; }

        public AddAuthorCommand(IMenu receiver) => this.receiver = receiver;

        protected override void Funс() => receiver.AddAuthor();
    }

    public class AddBookCommand : Command
    {
        private IMenu receiver { get; set; }

        public AddBookCommand(IMenu receiver) => this.receiver = receiver;

        protected override void Funс() => receiver.AddBook();
    }

    public class AddCustomerCommand : Command
    {
        private IMenu receiver;

        public AddCustomerCommand(IMenu receiver) => this.receiver = receiver;

        protected override void Funс() => receiver.AddCustomer();
    }

    public class AddEmployeeCommand : Command
    {
        private IMenu receiver;

        public AddEmployeeCommand(IMenu receiver) => this.receiver = receiver;

        protected override void Funс() => receiver.AddEmployee();
    }
}