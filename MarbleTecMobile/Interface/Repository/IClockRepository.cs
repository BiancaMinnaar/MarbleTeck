using System;
using System.Threading.Tasks;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Interface.Repository
{
    public interface IClockRepository
    {
        Task Clock(ClockViewModel model, Action completeAction);
    }
}
