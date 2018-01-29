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
    public class SmallTableMenuItemViewController : ProjectBaseViewController<SmallTableMenuItemViewModel>, ISmallTableMenuItemViewController
    {
        ISmallTableMenuItemRepository _Reposetory;
        ISmallTableMenuItemService _Service;

        public override void SetRepositories()
        {
            _MasterRepo.NetworkInterface = (U, P, A) => ExecuteQueryWithObjectAndNetworkAccessAsync(U, P, A);
            _MasterRepo.NetworkInterfaceWithTypedParameters = (U, P, A) => ExecuteQueryWithTypedParametersAndNetworkAccessAsync(U, P, A);
            _Service = new SmallTableMenuItemService(_MasterRepo.NetworkInterface);
            _Reposetory = new SmallTableMenuItemRepository(_MasterRepo, _Service);
        }

        public async Task SmallTableMenuItem()
        {
            
        }
    }
}