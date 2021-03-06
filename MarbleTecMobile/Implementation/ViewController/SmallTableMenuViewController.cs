using System.Threading.Tasks;
using System.Collections.Generic;
using MarbleTecMobile.Base;
using MarbleTecMobile.Implementation.Repository;
using MarbleTecMobile.Implementation.Service;
using MarbleTecMobile.Implementation.ViewModel;
using MarbleTecMobile.Interface.Repository;
using MarbleTecMobile.Interface.Service;
using MarbleTecMobile.Interface.ViewController;

namespace MarbleTecMobile.Implementation.ViewController
{
    public class SmallTableMenuViewController : ProjectBaseViewController<SmallTableMenuViewModel>, ISmallTableMenuViewController
    {
        ISmallTableMenuRepository _Reposetory;
        ISmallTableMenuService _Service;

        public override void SetRepositories()
        {
            _MasterRepo.NetworkInterface = (U, P, A) => ExecuteQueryWithObjectAndNetworkAccessAsync(U, P, A);
            _MasterRepo.NetworkInterfaceWithTypedParameters = (U, P, A) => ExecuteQueryWithTypedParametersAndNetworkAccessAsync(U, P, A);
            _Service = new SmallTableMenuService(_MasterRepo.NetworkInterface);
            _Reposetory = new SmallTableMenuRepository(_MasterRepo, _Service);
        }

        public async Task SmallTableMenu()
        {
            await _Reposetory.SmallTableMenu(InputObject, () =>
            {
                var menuCOl = DeserializeObject<List<SmallTableMenuItemViewModel>>(_ResponseContent);
                string dd = "";
            });
        }
    }
}