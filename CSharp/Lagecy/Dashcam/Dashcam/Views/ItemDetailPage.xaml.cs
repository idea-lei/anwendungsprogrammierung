using Dashcam.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Dashcam.Views
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