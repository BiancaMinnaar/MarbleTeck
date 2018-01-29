using System;
using System.Threading.Tasks;
using MarbleTecMobile.Interface.Service;
using MarbleTecMobile.Interface.Repository;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Implementation.Repository
{
    public class SmallTableMenuItemRepository : ProjectBaseRepository, ISmallTableMenuItemRepository
    {
        ISmallTableMenuItemService _Service;

        public SmallTableMenuItemRepository(IMasterRepository masterRepository, ISmallTableMenuItemService service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task SmallTableMenuItem(SmallTableMenuItemViewModel model, Action completeAction)
        {
            await _Service.SmallTableMenuItem(model);
            completeAction();
        }
    }
}