using ReproSwipe.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ReproSwipe.Views
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