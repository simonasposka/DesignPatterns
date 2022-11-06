using System;
using DesignPatterns.Command.Commands;

namespace DesignPatterns.Command
{
    // Acts as Invoker
    public class Calculator
    {
        public double Value { get; set; } = 0;
        public double SelectedNumber { get; set; } = 0;
        Invoker CommandInvoker { get; set; }
        
        public Calculator()
        {
            CommandInvoker = new Invoker(new Add(this), new Subtract(this));
        }

        public void Add()
        {
            CommandInvoker.Add();
        }

        public void Subtract()
        {
            CommandInvoker.Subtract();
        }

        public void SelectNumber(double number)
        {
            SelectedNumber = number;
        }

        public void Reset()
        {
            Value = 0;
            SelectedNumber = 0;
        }
    }
}

