using System.ComponentModel;
using Xamarin.Forms;
using SugarCalc.ViewModels;

namespace SugarCalc.Views
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