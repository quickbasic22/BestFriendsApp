using BestFriendsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BestFriendsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new AddContactViewModel();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}
