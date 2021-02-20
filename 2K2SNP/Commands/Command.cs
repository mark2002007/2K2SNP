namespace _2K2SNP.Commands
{
    public class Command : ICommand
    {
        public virtual void Execute()
        {
            Funk();
            CommandLogger.LogCommand(this);
        }

        protected virtual void Funk() { }
    };
};