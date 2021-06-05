using PassingDataToViewModel.ViewModels;
using PassingDataToViewModel.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PassingDataToViewModel
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(ParameterPage), typeof(ParameterPage));
            Routing.RegisterRoute(nameof(ModalPage), typeof(ModalPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
