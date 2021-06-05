using PassingDataToViewModel.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PassingDataToViewModel.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}