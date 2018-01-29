using System;
using System.Threading.Tasks;
using MarbleTecMobile.Interface.Service;
using MarbleTecMobile.Interface.Repository;
using MarbleTecMobile.Implementation.ViewModel;
using MarbleTecMobile.Implementation.Service;

namespace MarbleTecMobile.Implementation.Repository
{
    public class HomeRepository : ProjectBaseRepository, IHomeRepository
    {
        IHomeService _Service;

        public HomeRepository(IMasterRepository masterRepository, IHomeService service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task Home(HomeViewModel model, Action completeAction)
        {
            await _Service.Home(model);
            completeAction();
        }
		
        public async Task GetSmallTableMenu(HomeViewModel model, Action completeAction)
		{
            var smallTableMenuService = new SmallTableMenuService(_MasterRepo.NetworkInterface);
            var smallTableRepo = new SmallTableMenuRepository(_MasterRepo, smallTableMenuService);
            await smallTableRepo.SmallTableMenu(new SmallTableMenuViewModel(){MenuType="user"}, completeAction);
		}
    }
}