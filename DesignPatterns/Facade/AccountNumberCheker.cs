using System;
namespace DesignPatterns.Facade
{
    public class AccountNumberCheker
    {
        private int AccountNumber = 123456;

        public AccountNumberCheker() { }

        public bool IsAccountNumberActiveAndCorrect(int accountNumbToCheck)
        {
            return accountNumbToCheck == AccountNumber;
        }
    }
}

