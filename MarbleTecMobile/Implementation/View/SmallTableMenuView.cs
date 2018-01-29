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

        public void SetMenuWithItems(List<SmallTableMenuItemViewModel> dataSource, Action<object> clickEvent)
        {
            Menu.Children.Clear();
            for (var count = 0; count < dataSource.Count; count++)
            {
                var item = new SmallTableMenuItemViewModel() 
                { 
                    ListIndex=count, 
                    ItemDescription=dataSource[count].ItemDescription,
                    MenuClickedCommand = new Command(clickEvent)
                };
                var menuItem = new SmallTableMenuItemView(item);
                Menu.Children.Add(menuItem);
            }
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            _ViewController.ShowMessage("here");
        }
    }
}


