namespace DesignPatterns.Observer
{
    public class Client : Observer
    {
        protected int Id { get; set; }
        protected ChatRoom Observable { get; set; }

        // Client depends on observable in order to get it's state
        public Client(int clientId, ChatRoom observable)
        {
            Id = clientId;
            Observable = observable;
        }

        public override void Update()
        {
            var text = "";
            var messages = Observable.GetMessages();

            foreach(var message in messages)
            {
                text += message + "; ";
            }

            Console.WriteLine($"client: {Id} sees messages: {text}");
        }
    }
}

