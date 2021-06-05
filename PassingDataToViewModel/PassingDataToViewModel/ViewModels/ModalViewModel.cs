using System.Windows.Input;
using Xamarin.Forms;

namespace PassingDataToViewModel.ViewModels
{
    public class ModalViewModel : BaseViewModel
    {
        public ModalViewModel()
        {
            CloseCommand = new Command(async value => await Shell.Current.GoToAsync($"..?param2={value}"));
        }

        public ICommand CloseCommand { get; }
    }
}
