using DesignPatterns.Command.Commands;

namespace DesignPatterns.Command
{
    public class Invoker
    {
        protected ICommand AddCommand { get; set; }
        protected ICommand SubtractCommand { get; set; }
        protected ICommand PreviousCommand { get; set; }

        public Invoker(ICommand addCommand, ICommand subtractCommand)
        {
            AddCommand = addCommand;
            SubtractCommand = subtractCommand;
        }

        public void Add()
        {
            PreviousCommand = AddCommand;
            AddCommand.execute();
        }

        public void Subtract()
        {
            PreviousCommand = SubtractCommand;
            SubtractCommand.execute();
        }
    }
}

