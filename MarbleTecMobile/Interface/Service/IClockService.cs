using System.Threading.Tasks;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Interface.Service
{
    public interface IClockService
    {
        Task Clock(ClockViewModel model);
    }
}

