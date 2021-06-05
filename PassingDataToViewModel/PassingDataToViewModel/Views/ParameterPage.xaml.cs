using PassingDataToViewModel.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PassingDataToViewModel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParameterPage : ContentPage
    {
        public ParameterPage()
        {
            InitializeComponent();
            BindingContext = new ParameterViewModel();
        }
    }
}