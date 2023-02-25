using Calculater.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Calculater.Views
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