using PassingDataToViewModel.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PassingDataToViewModel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
            BindingContext = new ModalViewModel();
        }
    }
}