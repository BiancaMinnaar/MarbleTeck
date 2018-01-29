using System;
using System.Threading.Tasks;
using MarbleTecMobile.Interface.Service;
using MarbleTecMobile.Interface.Repository;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Implementation.Repository
{
    public class ClockRepository : ProjectBaseRepository, IClockRepository
    {
        IClockService _Service;

        public ClockRepository(IMasterRepository masterRepository, IClockService service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task Clock(ClockViewModel model, Action completeAction)
        {
            await _Service.Clock(model);
            completeAction();
        }
    }
}