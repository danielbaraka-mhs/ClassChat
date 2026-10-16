using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ClassChat.Models;

namespace ClassChat.ViewModels
{
    public class ContractsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ClassChat.Models.Contacts> Contacts { get; } = new ObservableCollection<ClassChat.Models.Contacts>();

        private ClassChat.Models.Contacts _selectedContact;
        public ClassChat.Models.Contacts SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (_selectedContact == value)
                    return;
                _selectedContact = value;
                OnPropertyChanged();
            }
        }

        public ContractsViewModel()
        {
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            var now = DateTime.Now;

            var alice = new ClassChat.Models.Contacts
            {
                Id = "1",
                Name = "Alice Johnson",
                ProfileImage = "dotnet_bot.png"
            };
            alice.Messages.Add(new Message { Id = "m1", Text = "Hey, are you available tomorrow?", Timestamp = now.AddMinutes(-50), IsIncoming = true, SenderName = "Alice Johnson", SenderImage = "dotnet_bot.png" });
            alice.Messages.Add(new Message { Id = "m2", Text = "Yes, let's meet at 10.", Timestamp = now.AddMinutes(-45), IsIncoming = false, SenderName = "Me", SenderImage = "dotnet_bot.png" });

            var bob = new ClassChat.Models.Contacts
            {
                Id = "2",
                Name = "Bob Smith",
                ProfileImage = "dotnet_bot.png"
            };
            bob.Messages.Add(new Message { Id = "m3", Text = "Can you review my code?", Timestamp = now.AddHours(-3), IsIncoming = true, SenderName = "Bob Smith", SenderImage = "dotnet_bot.png" });

            var carol = new ClassChat.Models.Contacts
            {
                Id = "3",
                Name = "Carol Lee",
                ProfileImage = "dotnet_bot.png"
            };
            carol.Messages.Add(new Message { Id = "m4", Text = "Thanks for the update.", Timestamp = now.AddDays(-1), IsIncoming = false, SenderName = "Me", SenderImage = "dotnet_bot.png" });

            Contacts.Add(alice);
            Contacts.Add(bob);
            Contacts.Add(carol);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
