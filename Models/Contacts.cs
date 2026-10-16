using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ClassChat.Models
{
    public class Contacts
    {
        public string Id { get; set; }
        public string Name { get; set; }
        // Image resource name or URI
        public string ProfileImage { get; set; }

        public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();

        public string LastMessage => Messages?.LastOrDefault()?.Text ?? string.Empty;

        public DateTime? LastMessageTime => Messages?.LastOrDefault()?.Timestamp;
    }
}
