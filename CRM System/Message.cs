namespace CRM_System
{
    public class Message
    {
        public string Id { get;}
        public string Name { get; set; }
        public string MessageText { get; set; }
        public Message(string name, string messageText)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            MessageText = messageText;
        }
    }
}
