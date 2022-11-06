using System;
namespace DesignPatterns.Facade
{
    public class Facade
    {
        private int AccountNumber { get; set; }
        private int SecurityCode { get; set; }

        private AccountNumberCheker AccountNumberCheker { get; set; }
        private SecurityCodeCheker SecurityCodeCheker { get; set; }
        private FundsLogic FundsLogic { get; set; }

        public Facade(int accountNumber, int securityCode)
        {
            AccountNumber = accountNumber;
            SecurityCode = securityCode;

            AccountNumberCheker = new AccountNumberCheker();
            SecurityCodeCheker = new SecurityCodeCheker();
            FundsLogic = new FundsLogic();
        }

        public void WithdrawMoney(double amount)
        {
            if (AccountNumberCheker.IsAccountNumberActiveAndCorrect(AccountNumber)
                && SecurityCodeCheker.CheckSecurityCode(SecurityCode)
                    && FundsLogic.HasEnoughMoney(amount))
            {
                FundsLogic.WithdrawMoney(amount);
                Console.WriteLine("Succesfully withdraw! Balance: " + FundsLogic.Funds);
            }
            else
            {
                Console.WriteLine("Withdraw failed!");
            }
        }

        public void DepositCash(double amount)
        {
            if (AccountNumberCheker.IsAccountNumberActiveAndCorrect(AccountNumber)
                && SecurityCodeCheker.CheckSecurityCode(SecurityCode))
            {
                FundsLogic.IncreaseMoneyInAcc(amount);
                Console.WriteLine("Succesfully increased! Balance: " + FundsLogic.Funds);
            }
            else
            {
                Console.WriteLine("Deposit failed");
            }
        }
    }
}

