using MarbleTecMobile.Implementation.Repository;
using MarbleTecMobile.Implementation.View;
using Xamarin.Forms;

namespace MarbleTecMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var _MasterRepo = MasterRepository.MasterRepo;
            _MasterRepo.SetRootView(new NavigationPage(new LoginView()));
            //_MasterRepo.SetRootView(new NavigationPage(new TestHarnesView()));
            MainPage = _MasterRepo.GetRootView();
        }
    }
}
