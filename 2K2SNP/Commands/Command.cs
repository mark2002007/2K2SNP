namespace _2K2SNP.Commands
{
    public class Command : ICommand
    {
        public virtual void Execute()
        {
            Funс();
            CommandLogger.LogCommand(this);
        }

        protected virtual void Funс() { }
    };
};