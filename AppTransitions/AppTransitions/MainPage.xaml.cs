using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTransitions
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(string.Empty));
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tappedItemData = e.Item as string;
            //this is required in order to pass the views to animate
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, tappedItemData);
            await Navigation.PushAsync(new Page1(tappedItemData));
        }
    }
}
