using MyMobleApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyMobleApp.Views
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