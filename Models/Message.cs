using System;

namespace ClassChat.Models
{
    public class Message
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsIncoming { get; set; }
        public string SenderName { get; set; }
        public string SenderImage { get; set; }
    }
}
