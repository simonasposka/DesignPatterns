namespace DesignPatterns.Observer
{
    public class Main
    {
        /*
         * Observer pattern
         *
         * Type: Behavioral
         *
         * Intent: Define a one-to-many dependency between objects so that
         * when one object changes state, all its dependents are notified and
         * updated automatically.
         */
        public Main()
        {
        }

        public static void Run()
        {
            ChatRoom chatRoom = new ChatRoom(); // <- Observable class

            Observer client1 = new Client(1, chatRoom);
            Observer client2 = new Client(2, chatRoom);
            Observer client3 = new Client(3, chatRoom);

            chatRoom.Add(client1);
            chatRoom.Add(client2);
            chatRoom.Add(client3);
            chatRoom.Notify();

            chatRoom.AddMessage("Hello, world!");
            chatRoom.Notify(); // all 3 clients sees "hello, world!" message

            chatRoom.AddMessage("Bye bye, world!"); 
            chatRoom.Notify(); // all 3 clients sees "hello, world!, Bye bye, world!" messages
        }
    }
}

