using Pitaru_Cosmin_Lab12_xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Pitaru_Cosmin_Lab12_xamarin.Views
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