namespace DesignPatterns.Command.Commands
{
    public class Add : ICommand
    {
        protected Calculator Calculator { get; set; }

        public Add(Calculator calculator)
        {
            Calculator = calculator;
        }

        public void execute()
        {
            Calculator.Value += Calculator.SelectedNumber;
        }

        public void unexecute()
        {
            Calculator.Value -= Calculator.SelectedNumber;
        }
    }
}

