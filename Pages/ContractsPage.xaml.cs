using System;
using ClassChat.Models;
using ClassChat.ViewModels;
using Microsoft.Maui.Controls;

namespace ClassChat.Pages
{
    public partial class ContractsPage : ContentPage
    {
        ContractsViewModel vm;

        public ContractsPage()
        {
            InitializeComponent();
            vm = new ContractsViewModel();
            BindingContext = vm;
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection == null || e.CurrentSelection.Count == 0)
                return;

            var contact = e.CurrentSelection[0] as ClassChat.Models.Contacts;
            if (contact == null)
                return;

            // deselect
            ((CollectionView)sender).SelectedItem = null;

            // navigate to chat page
            await Navigation.PushAsync(new ChatPage(contact));
        }
    }
}
