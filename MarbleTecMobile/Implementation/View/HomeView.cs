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
            On_Home_Event(null, null);
        }

        protected override void SetSVGCollection()
        {
        }

        public async void On_Home_Event(object sender, EventArgs e)
        {
            await _ViewController.Home();
            Menu.SetMenuWithItems(_ViewController.InputObject.MenuItems, MenuClick);
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _ViewController.InputObject.MenuItems.Add(new SmallTableMenuItemViewModel()
            {
                ListIndex = _ViewController.InputObject.MenuItems.Count,
                ItemDescription = "New Item"
            });
            Menu.SetMenuWithItems(_ViewController.InputObject.MenuItems, MenuClick);
        }

        void MenuClick(object index)
        {
            var timeModel = new ClockViewModel()
            {
                FullDate = DateTime.Now
            };
            Detail.Content = new ClockView(timeModel);
        }

        void Handle_DrawMenu(object sender, PanUpdatedEventArgs e)
        {
            var translatedX = e.TotalX;
            var translatedY = e.TotalY;

            if (translatedY < 0 && Math.Abs(translatedY) > Math.Abs(translatedX))
            {
                DrawMenuContent.HeightRequest = 0.0;
            }
            else if (translatedY > 0 && translatedY > Math.Abs(translatedX))
            {
                DrawMenuContent.HeightRequest = 100.0;
            }
        }
    }
}


