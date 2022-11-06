namespace DesignPatterns.Facade
{
    /*
     * Facade pattern 
     *
     * Type: Structural
     *
     * Intent: provide a simplified interface to a library, a framework,
     * or any other complex set of classes.
     */
    public class Main
    {
        public Main()
        {
        }

        public static void Run()
        {
            var accountNumber = 123456;
            var securityCode = 1234;

            Facade bankFacade = new Facade(accountNumber, securityCode);
            bankFacade.DepositCash(100);
            bankFacade.WithdrawMoney(500);
            bankFacade.WithdrawMoney(100);
            bankFacade.WithdrawMoney(600);
        }
    }
}

