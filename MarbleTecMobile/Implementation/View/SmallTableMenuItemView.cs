using System;
using Xamarin.Forms;
using MarbleTecMobile.Implementation.ViewController;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Implementation.View
{
    public partial class SmallTableMenuItemView : ProjectBaseContentView<SmallTableMenuItemViewController, SmallTableMenuItemViewModel>
    {
        public SmallTableMenuItemView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        public SmallTableMenuItemView(SmallTableMenuItemViewModel model) :this()
        {
            _ViewController.InputObject = model;
        }

        protected override void SetSVGCollection()
        {
        }
    }
}


