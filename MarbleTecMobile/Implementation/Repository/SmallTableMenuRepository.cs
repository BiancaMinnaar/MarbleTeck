using System;
using System.Threading.Tasks;
using MarbleTecMobile.Interface.Service;
using MarbleTecMobile.Interface.Repository;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Implementation.Repository
{
    public class SmallTableMenuRepository : ProjectBaseRepository, ISmallTableMenuRepository
    {
        ISmallTableMenuService _Service;

        public SmallTableMenuRepository(IMasterRepository masterRepository, ISmallTableMenuService service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task SmallTableMenu(SmallTableMenuViewModel model, Action completeAction)
        {
            await _Service.SmallTableMenu(model);
            completeAction();
        }
    }
}