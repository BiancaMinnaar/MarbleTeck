using System.Threading.Tasks;
using MarbleTecMobile.Implementation.ViewModel;

namespace MarbleTecMobile.Interface.Service
{
    public interface ISmallTableMenuItemService
    {
        Task SmallTableMenuItem(SmallTableMenuItemViewModel model);
    }
}

