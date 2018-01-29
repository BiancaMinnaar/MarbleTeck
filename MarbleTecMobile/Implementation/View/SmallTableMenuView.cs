using System;
using Xamarin.Forms;
using MarbleTecMobile.Implementation.ViewController;
using MarbleTecMobile.Implementation.ViewModel;
using System.Collections.Generic;

namespace MarbleTecMobile.Implementation.View
{
    public partial class SmallTableMenuView : ProjectBaseContentView<SmallTableMenuViewController, SmallTableMenuViewModel>
    {
        List<SmallTableMenuItemViewModel> DataSource { get; set; }

        public SmallTableMenuView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public void SetMenuWithItems(List<SmallTableMenuItemViewModel> dataSource)
        {
            foreach(var item in dataSource)
            {
                var menuItem = new SmallTableMenuItemView(item);
                Menu.Children.Add(menuItem);
            }
        }
    }
}


