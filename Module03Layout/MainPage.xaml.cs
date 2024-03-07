using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module03Layout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnStackLayoutPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutPage());
        }

        private async void OnAbsoluteLayoutPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutPage());
        }
        private async void OnRelativeLayoutPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeLayoutPage());
        }
        private async void OnGridLayoutPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage());
        }
    }
}
