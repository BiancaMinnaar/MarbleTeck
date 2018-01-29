using System;
using Xamarin.Forms;
using MarbleTecMobile.Implementation.ViewController;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Implementation.View
{
    public partial class ClockView : ProjectBaseContentPage<ClockViewController, ClockViewModel>
    {
        public ClockView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public async void On_Clock_Event(object sender, EventArgs e)
        {
            await _ViewController.Clock();
        }
    }
}


