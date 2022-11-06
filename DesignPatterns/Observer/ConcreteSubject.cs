namespace DesignPatterns.Observer
{
    // Concrete Subject -> this could be ChatRoom
    public class ChatRoom : Subject
    {
        protected List<String> messages = new List<String>();

        public ChatRoom()
        {
        }

        public void AddMessage(string message)
        {
            messages.Add(message);
        }

        public List<String> GetMessages()
        {
            return messages;
        }
    }
}