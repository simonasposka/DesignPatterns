namespace DesignPatterns.Command.Commands
{
    public class Subtract : ICommand
    {
        protected Calculator Calculator { get; set; }

        public Subtract(Calculator calculator)
        {
            Calculator = calculator;
        }

        public void execute()
        {
            Calculator.Value -= Calculator.SelectedNumber;
            Calculator.SelectedNumber = Calculator.Value;
        }

        public void unexecute()
        {
            Calculator.Value += Calculator.SelectedNumber;
            Calculator.SelectedNumber = Calculator.Value;
        }
    }
}

