using PassingDataToViewModel.Views;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace PassingDataToViewModel.ViewModels
{
    public class ParameterViewModel : BaseViewModel, IQueryAttributable
    {
        private string param1;
        private string param2;

        public ParameterViewModel()
        {
            OpenModalCommand = new Command(async () => await Shell.Current.GoToAsync($"{nameof(ModalPage)}"));
        }

        public string Param1 
        { 
            get => param1; 
            set => SetProperty(ref param1, value); 
        }

        public string Param2 
        { 
            get => param2; 
            set => SetProperty(ref param2, value); 
        }

        public ICommand OpenModalCommand { get; }

        public void ApplyQueryAttributes(IDictionary<string, string> query)
        {
            if (query.TryGetValue("param1", out var param1))
            {
                this.Param1 = param1;
            }

            if (query.TryGetValue("param2", out var param2))
            {
                this.Param2 = param2;
            }
        }
    }
}
