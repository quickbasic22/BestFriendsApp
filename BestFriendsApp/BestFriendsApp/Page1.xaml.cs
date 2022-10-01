using BestFriendsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BestFriendsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            var item = page1 as Page1;
            item.ChildAdded += Item_ChildAdded;
            BindingContext = new Page1ViewModel();
        }

        private void Item_ChildAdded(object sender, ElementEventArgs e)
        {
            MyLabel.Text += e.Element.ToString();
        }
    }
}