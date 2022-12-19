namespace DesignPatterns.ChainOfResponsibility
{
    public class Main
    {
        /*
         * ChainOfResponsibility pattern
         *
         * Type: behavioral
         *
         * Intent: Avoid coupling the sender of a request to its receiver by giving more than one object a chance
         * to handle the request. Chain the receiving objects and pass the request along the chain until
         * an object handles it
         */
        public Main()
        {
        }

        public static void Run()
        {
            var database = new Database();
            var handler = new UserExistsHandler(database)
                .SetNextHandler(new ValidPasswordHandler(database))
                .SetNextHandler(new ValidRoleHandler());

            var authService = new AuthService(handler);
            authService.LogIn("admin_username", "asd");
        }
    }
}