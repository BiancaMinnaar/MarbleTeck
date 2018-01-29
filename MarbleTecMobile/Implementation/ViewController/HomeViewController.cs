using System.Threading.Tasks;
using MarbleTecMobile.Base;
using MarbleTecMobile.Implementation.Repository;
using MarbleTecMobile.Implementation.Service;
using MarbleTecMobile.Implementation.ViewModel;
using MarbleTecMobile.Interface.Repository;
using MarbleTecMobile.Interface.Service;
using MarbleTecMobile.Interface.ViewController;

namespace MarbleTecMobile.Implementation.ViewController
{
    public class HomeViewController : ProjectBaseViewController<HomeViewModel>, IHomeViewController
    {
        IHomeRepository _Reposetory;
        IHomeService _Service;

        public override void SetRepositories()
        {
            _MasterRepo.NetworkInterface = (U, P, A) => ExecuteQueryWithObjectAndNetworkAccessAsync(U, P, A);
            _MasterRepo.NetworkInterfaceWithTypedParameters = (U, P, A) => ExecuteQueryWithTypedParametersAndNetworkAccessAsync(U, P, A);
            _Service = new HomeService(_MasterRepo.NetworkInterface);
            _Reposetory = new HomeRepository(_MasterRepo, _Service);
        }

        public async Task Home()
        {
            
        }
    }
}