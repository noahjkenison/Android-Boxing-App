using BoxingProto.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BoxingProto.Views
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