using PassingDataToViewModel.Models;
using PassingDataToViewModel.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PassingDataToViewModel.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            OpenParameterPageCommand = new Command(async () => await Shell.Current.GoToAsync($"{nameof(ParameterPage)}?param1=1&param2=2"));
        }

        public ICommand OpenWebCommand { get; }

        public ICommand OpenParameterPageCommand { get; }
    }
}