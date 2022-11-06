using System;
namespace DesignPatterns.Facade
{
    public class FundsLogic
    {
        public double Funds { get; set; } = 1000.0;

        public FundsLogic()
        {
        }

        public void DecreaseMoneyInAcc(double amount)
        {
            Funds -= amount;
        }

        public void IncreaseMoneyInAcc(double amount)
        {
            Funds += amount;
        }

        public bool HasEnoughMoney(double amount)
        {
            return Funds >= amount;
        }

        public void WithdrawMoney(double amount)
        {
            if (HasEnoughMoney(amount))
            {
                DecreaseMoneyInAcc(amount);
                Console.WriteLine("Withdrawal complete!" + " Funds Left: " + Funds);
            } else {
                Console.WriteLine("Withdrawal failed!");
            }
        }

        public void MakeDeposit(double amount)
        {
            IncreaseMoneyInAcc(amount);
            Console.WriteLine("Succesful deposit! Current account balance: " + Funds);
        }
    }
}