using System;
using ClassChat.Models;
using Microsoft.Maui.Controls;

namespace ClassChat.Pages
{
    public partial class ChatPage : ContentPage
    {
        private ClassChat.Models.Contacts _contact;

        public ChatPage(ClassChat.Models.Contacts contact)
        {
            InitializeComponent();
            _contact = contact ?? throw new ArgumentNullException(nameof(contact));
            BindingContext = _contact;
        }

        private void SendButton_Clicked(object sender, EventArgs e)
        {
            var text = MessageEntry.Text?.Trim();
            if (string.IsNullOrEmpty(text))
                return;

            var msg = new Message
            {
                Id = Guid.NewGuid().ToString(),
                Text = text,
                Timestamp = DateTime.Now,
                IsIncoming = false,
                SenderName = "Me",
                SenderImage = "dotnet_bot.png"
            };

            _contact.Messages.Add(msg);

            // clear entry and scroll to last
            MessageEntry.Text = string.Empty;
            if (MessagesCollection.ItemsSource is System.Collections.IList list)
                MessagesCollection.ScrollTo(msg);
        }
    }
}
