using _2K2SNP.Repositories;
using _2K2SNP.Menu;

namespace _2K2SNP.Commands { 
    public class RemoveAuthorCommand : Command
    {
        private IMenu receiver { get; set; }

        public RemoveAuthorCommand(IMenu receiver) => this.receiver = receiver;

        protected override void Funk() => receiver.RemoveAuthor();
    }

    public class RemoveBookCommand : Command
    {
        private IMenu receiver { get; set; }

        public RemoveBookCommand(IMenu receiver) => this.receiver = receiver;

        protected override void Funk() => receiver.RemoveBook();
    }

    public class RemoveCustomerCommand : Command
    {
        private IMenu receiver { get; set; }

        public RemoveCustomerCommand(IMenu receiver) => this.receiver = receiver;

        protected override void Funk() => receiver.RemoveCustomer();
    }

    public class RemoveEmployeeCommand : Command
    {
        private IMenu receiver { get; set; }

        public RemoveEmployeeCommand(IMenu receiver) => this.receiver = receiver;

        protected override void Funk() => receiver.RemoveEmployee();
    }
}