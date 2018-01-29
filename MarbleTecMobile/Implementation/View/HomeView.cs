using System;
using Xamarin.Forms;
using MarbleTecMobile.Implementation.ViewController;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Implementation.View
{
    public partial class HomeView : ProjectBaseContentPage<HomeViewController, HomeViewModel>
    {
        public HomeView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public async void On_Home_Event(object sender, EventArgs e)
        {
            await _ViewController.Home();
        }
    }
}


