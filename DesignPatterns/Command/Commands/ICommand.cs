namespace DesignPatterns.Command.Commands
{
    public interface ICommand
    {
        public void execute();
        public void unexecute();
    }
}

